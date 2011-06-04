using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Windows;
using Microsoft.Win32;

namespace LoLStarter
{
    class Configuration
    {
        public string Folderpath;
        public string LocaleCFG;
        public string SystemCFG;
        public string LauncherCFG;
        public string LoLStarterCFG = "lolstarter.cfg";
        public string GlobalPropertiesPath;
        public string PatchRegion;
        public string EULang = "en_GB";
        public string USLang = "en_US";
        public String LastServer = "";
        public string LauncherFile;
        public string SystemFile;
        public string LocaleFile;
        public string ConfigFile;

        public Configuration() {
            getLoLInstallPath();
            getLoLCFGs();
        }

        public void getLoLCFGs()
        {
            LocaleCFG = Folderpath + "\\RADS\\system\\locale.cfg";
            LauncherCFG = Folderpath + "\\RADS\\system\\launcher.cfg";
            SystemCFG = Folderpath + "\\RADS\\system\\system.cfg";
        }

        public void getGlobalProperties() {
            if (LastServer.ToLower().Equals("unknown"))
            {
                return;
            }
            String result = getPropertiesFileName(LastServer);
            String source = getReleasePath();

            if (File.Exists(result))
            {
                System.IO.File.SetAttributes(result, FileAttributes.Normal);
                System.IO.File.Delete(result);
            }
            System.IO.File.Copy(source, result);
        }

        public void writeGlobalProperties(String server)
        {
            String result = getReleasePath();
            String source = getPropertiesFileName(server);
            if (LastServer.ToLower().Equals("unknown") || source.ToLower().Equals("unknown"))
            {
                return;
            }
            getGlobalProperties();
            LastServer = server;
            try
            {
                if (File.Exists(result) && File.Exists(source))
                {
                    System.IO.File.SetAttributes(result, FileAttributes.Normal);
                    System.IO.File.Delete(result);
                    System.IO.File.Copy(source, result);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        private String getPropertiesFileName(String server) {
            String file = "global.properties";
            if (server.ToLower().Equals("eu"))
            {
                return "eu." + file;
            }
            if (server.ToLower().Equals("na"))
            {
                return "eu." + file;
            }
            return "unknown";
        }

        public String getReleasePath()
        {
            String Path = Folderpath + "\\RADS\\projects\\lol_air_client\\releases\\";
            List<String> folders = new List<String>();
            Char[] splitter = new Char[] { };
            if (!Directory.Exists(Path))
            {
                return Path;
            }
            foreach (string dn in Directory.GetDirectories(Path))
            {
                if (File.Exists(dn + "\\deploy\\preferences\\global\\global.properties"))
                    Path = dn + "\\deploy\\preferences\\global\\global.properties";
            }
            GlobalPropertiesPath = Path;
            return Path;
        }

        //public void validPatcher()
        //{
        //    if (PatchRegion == null || PatchRegion == "")
        //        readPatchRegion();
        //}

        public void readPatchRegion()
        {
            String result = SystemCFG;
            using (StreamReader sr = new StreamReader(result))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Region"))
                    {
                        if (line.Contains("NA"))
                        {
                            PatchRegion = "NA";
                        }
                        if (line.Contains("EU"))
                        {
                            PatchRegion = "EU";
                        }
                    }
                }
                sr.Close();
            }
        }

        public void getLang()
        {
            String result = LocaleCFG;
            using (StreamReader sr = new StreamReader(result))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("locale"))
                    {
                        String tmp = line.Substring(line.IndexOf("=") + 1, line.Length - line.IndexOf("=") - 1);
                        if (tmp.ToLowerInvariant().Contains("en_us") && EULang.Contains("unknown"))
                            EULang = "en_GB";
                        else if (tmp.ToLowerInvariant().Contains("en_na") && EULang.Contains("unknown"))
                            EULang = "en_GB";
                        else
                            EULang = tmp;
                    }
                }
                sr.Close();
            }
        }


        public void saveCFG()
        {
            TextWriter tw = new StreamWriter(LoLStarterCFG);
            tw.WriteLine(Folderpath);
            tw.WriteLine(EULang);
            tw.WriteLine(USLang);
            tw.WriteLine(PatchRegion);
            tw.WriteLine(LastServer);
            tw.Close();
        }

        public void writeSystemCFG(String client)
        {
            String result = SystemCFG;
            String source = "tempUACpath" + "\\system.cfg.tmp";
            using (StreamReader sr = new StreamReader(result))
            {
                TextWriter tw = new StreamWriter(source);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Region"))
                        tw.WriteLine("Region=" + client);
                    else
                        tw.WriteLine(line);
                }
                sr.Close();
                tw.Close();
                System.IO.File.SetAttributes(result, FileAttributes.Normal);
                System.IO.File.Delete(result);
                System.IO.File.Move(source, result);
            }
        }

        public void writeLocaleCFG(String lang)
        {
            String result = LocaleCFG;
            String source = "tempUACpath" + "\\locale.cfg.tmp";
            if (lang == "unknown")
                lang = "en_GB";
            try
            {
                using (StreamReader sr = new StreamReader(result))
                {
                    TextWriter tw = new StreamWriter(source);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("locale"))
                            tw.WriteLine("locale=" + lang);
                        else
                            tw.WriteLine(line);
                    }
                    sr.Close();
                    tw.Close();
                    System.IO.File.SetAttributes(result, FileAttributes.Normal);
                    System.IO.File.Delete(result);
                    System.IO.File.Move(source, result);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void writeLauncherCFG(String client)
        {
            String result = LauncherCFG;
            String source = "tempUACpath" + "\\launcher.cfg.tmp";
            try
            {
                using (StreamReader sr = new StreamReader(result))
                {
                    TextWriter tw = new StreamWriter(source);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("airConfigProject"))
                            tw.WriteLine("airConfigProject=lol_air_client_config_" + client);
                        else
                            tw.WriteLine(line);
                    }
                    sr.Close();
                    tw.Close();
                    System.IO.File.SetAttributes(result,FileAttributes.Normal);
                    System.IO.File.Delete(result);
                    System.IO.File.Move(source, result);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        //public void reReadAllFiles() {
        //    saveCFG();
        //    String result = LoLStarterCFG;
        //    if (File.Exists(result))
        //    {
        //        try
        //        {
        //            using (StreamReader sr = new StreamReader(result))
        //            {
        //                String line;
        //                int i = 0;
        //                ConfigFile = null;
        //                while ((line = sr.ReadLine()) != null)
        //                {
        //                    i++;
        //                    if (ConfigFile == null)
        //                        ConfigFile = line;
        //                    else
        //                        ConfigFile = ConfigFile + Environment.NewLine + line;
        //                }
        //                sr.Close();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            ConfigFile = ConfigFile + "An error occured while reading lol-starter.cfg: " + e.Message;
        //        }
        //    }

        //    if (getLoLCFGs())
        //    {
        //        result = LocaleCFG;
        //        try
        //        {
        //            using (StreamReader sr = new StreamReader(result))
        //            {
        //                String line;
        //                LocaleFile = null;
        //                while ((line = sr.ReadLine()) != null)
        //                {
        //                    if (LocaleFile == null)
        //                        LocaleFile = line;
        //                    else
        //                        LocaleFile = LocaleFile + Environment.NewLine + line;
        //                }
        //                sr.Close();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            LocaleFile = LocaleFile + "An error occured while reading your launcher.cfg: " + e.Message;
        //        }


        //        result = SystemCFG;
        //        try
        //        {
        //            using (StreamReader sr = new StreamReader(result))
        //            {
        //                String line;
        //                SystemFile = null;
        //                while ((line = sr.ReadLine()) != null)
        //                {
        //                    if (SystemFile == null)
        //                        SystemFile = line;
        //                    else
        //                        SystemFile = SystemFile + Environment.NewLine + line;

        //                }
        //                sr.Close();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            SystemFile = SystemFile + "An error occured while reading your system.cfg: " + e.Message;
        //        }


        //        result = LauncherCFG;
        //        try
        //        {
        //            using (StreamReader sr = new StreamReader(result))
        //            {
        //                String line;
        //                LauncherFile = null;
        //                while ((line = sr.ReadLine()) != null)
        //                {
        //                    if (LauncherFile == null)
        //                        LauncherFile = line;
        //                    else
        //                        LauncherFile = LauncherFile + Environment.NewLine + line;

        //                }
        //                sr.Close();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            LauncherFile = LauncherFile + "An error occured while reading your launcher.cfg: " + e.Message;
        //        }
        //    }
        //}

        public void readCFG()
        {
            if (File.Exists(LoLStarterCFG))
            {
                using (StreamReader sr = new StreamReader(LoLStarterCFG))
                {
                    String line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (i == 0)Folderpath = line;
                        if (i == 1)EULang = line;
                        if (i == 2)USLang = line;
                        if (i == 3)PatchRegion = line;
                        if (i == 4)LastServer = line;
                        i++;
                    }
                    sr.Close();
                }
            }
        }

        public void getLoLInstallPath()
        {
            if (File.Exists(LoLStarterCFG))
                readCFG();
            else
            {
                //if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Riot Games\\RADS") != null)
                //{
                //    RegistryKey riotKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Riot Games\\RADS");
                //    String temp = (string)riotKey.GetValue("LocalRootFolder");
                //    Folderpath = temp.Substring(0, temp.IndexOf("/RADS"));
                //}
                //if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Riot Games\\RADS") != null)
                //{
                //    RegistryKey riotKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Riot Games\\RADS");
                //    String temp = (string)riotKey.GetValue("LocalRootFolder");
                //    Folderpath = temp.Substring(0, temp.IndexOf("/RADS"));
                //}
                return;
            }
        }
    }
}
