using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace LoLStarter
{
    public partial class LoLStarter : Form
    {
        Configuration configuration;

        public LoLStarter()
        {
            InitializeComponent();
            configuration = new Configuration();
            ttLang.SetToolTip(lbCurLang, "You can change the preferred language in the settings tab.");
        }

        private void LoLStarter_Load(object sender, EventArgs e)
        {
            lbCurLang.Text = gbEULang.SelectedRadioButton().Text;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            lbCurLang.Text = gbEULang.SelectedRadioButton().Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fbdInstallFolder.ShowDialog();
            String path = fbdInstallFolder.SelectedPath;
            if (path != null && path != "")
            {
                tbInstallpath.Text = path;
            }
        }

        private void btnEU_Click(object sender, EventArgs e)
        
        {
            if (File.Exists(configuration.Folderpath + "\\lol.launcher.exe"))
            {
                setServer("eu");
                Process.Start(configuration.Folderpath + "\\lol.launcher.exe");
                this.Close();
            }
        }

        private void btnUS_Click(object sender, EventArgs e)
        {
            if (File.Exists(configuration.Folderpath + "\\lol.launcher.exe"))
            {
                setServer("na");
                Process.Start(configuration.Folderpath + "\\lol.launcher.exe");
                this.Close();
            }
        }

        private void setServer(String server)
        {
            configuration.saveCFG();
            configuration.writeGlobalProperties(server);
            configuration.writeLauncherCFG(server);
            if (server.ToLower().Equals("eu"))
            {
                if (configuration.EULang.Equals("unknown"))
                    configuration.EULang = "en_GB";
                if (String.Equals(configuration.EULang.ToLower(), "en_us"))
                    configuration.EULang = "en_GB";
                configuration.writeLocaleCFG(configuration.EULang);
            }
            else
            {
                configuration.writeLocaleCFG(configuration.USLang);
            }
        }
    }
}
