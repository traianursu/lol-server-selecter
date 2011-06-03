namespace LoLStarter
{
    partial class LoLStarter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoLStarter));
            this.Servers = new System.Windows.Forms.TabControl();
            this.tabServers = new System.Windows.Forms.TabPage();
            this.gbUS = new System.Windows.Forms.GroupBox();
            this.btnUS = new System.Windows.Forms.Button();
            this.gbEU = new System.Windows.Forms.GroupBox();
            this.lbCurLang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEU = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.gbEULang = new System.Windows.Forms.GroupBox();
            this.rbPL = new System.Windows.Forms.RadioButton();
            this.rbES = new System.Windows.Forms.RadioButton();
            this.rbFR = new System.Windows.Forms.RadioButton();
            this.rbDE = new System.Windows.Forms.RadioButton();
            this.rbEN = new System.Windows.Forms.RadioButton();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.ttLang = new System.Windows.Forms.ToolTip(this.components);
            this.Servers.SuspendLayout();
            this.tabServers.SuspendLayout();
            this.gbUS.SuspendLayout();
            this.gbEU.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.gbEULang.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Servers
            // 
            this.Servers.Controls.Add(this.tabServers);
            this.Servers.Controls.Add(this.tabSettings);
            this.Servers.Controls.Add(this.tabAbout);
            this.Servers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Servers.Location = new System.Drawing.Point(0, 0);
            this.Servers.Name = "Servers";
            this.Servers.SelectedIndex = 0;
            this.Servers.Size = new System.Drawing.Size(344, 322);
            this.Servers.TabIndex = 0;
            // 
            // tabServers
            // 
            this.tabServers.Controls.Add(this.gbUS);
            this.tabServers.Controls.Add(this.gbEU);
            this.tabServers.Location = new System.Drawing.Point(4, 22);
            this.tabServers.Name = "tabServers";
            this.tabServers.Padding = new System.Windows.Forms.Padding(3);
            this.tabServers.Size = new System.Drawing.Size(336, 296);
            this.tabServers.TabIndex = 0;
            this.tabServers.Text = "Servers";
            this.tabServers.UseVisualStyleBackColor = true;
            // 
            // gbUS
            // 
            this.gbUS.Controls.Add(this.btnUS);
            this.gbUS.Location = new System.Drawing.Point(8, 134);
            this.gbUS.Name = "gbUS";
            this.gbUS.Size = new System.Drawing.Size(320, 100);
            this.gbUS.TabIndex = 3;
            this.gbUS.TabStop = false;
            this.gbUS.Text = "US";
            // 
            // btnUS
            // 
            this.btnUS.Location = new System.Drawing.Point(239, 71);
            this.btnUS.Name = "btnUS";
            this.btnUS.Size = new System.Drawing.Size(75, 23);
            this.btnUS.TabIndex = 0;
            this.btnUS.Text = "Start";
            this.btnUS.UseVisualStyleBackColor = true;
            // 
            // gbEU
            // 
            this.gbEU.Controls.Add(this.lbCurLang);
            this.gbEU.Controls.Add(this.label1);
            this.gbEU.Controls.Add(this.btnEU);
            this.gbEU.Location = new System.Drawing.Point(8, 6);
            this.gbEU.Name = "gbEU";
            this.gbEU.Size = new System.Drawing.Size(320, 100);
            this.gbEU.TabIndex = 2;
            this.gbEU.TabStop = false;
            this.gbEU.Text = "EU";
            // 
            // lbCurLang
            // 
            this.lbCurLang.AutoSize = true;
            this.lbCurLang.Location = new System.Drawing.Point(108, 20);
            this.lbCurLang.Name = "lbCurLang";
            this.lbCurLang.Size = new System.Drawing.Size(35, 13);
            this.lbCurLang.TabIndex = 2;
            this.lbCurLang.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Language:";
            // 
            // btnEU
            // 
            this.btnEU.Location = new System.Drawing.Point(239, 71);
            this.btnEU.Name = "btnEU";
            this.btnEU.Size = new System.Drawing.Size(75, 23);
            this.btnEU.TabIndex = 0;
            this.btnEU.Text = "Start";
            this.btnEU.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.gbEULang);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(336, 296);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // gbEULang
            // 
            this.gbEULang.Controls.Add(this.rbPL);
            this.gbEULang.Controls.Add(this.rbES);
            this.gbEULang.Controls.Add(this.rbFR);
            this.gbEULang.Controls.Add(this.rbDE);
            this.gbEULang.Controls.Add(this.rbEN);
            this.gbEULang.Location = new System.Drawing.Point(8, 6);
            this.gbEULang.Name = "gbEULang";
            this.gbEULang.Size = new System.Drawing.Size(97, 140);
            this.gbEULang.TabIndex = 0;
            this.gbEULang.TabStop = false;
            this.gbEULang.Text = "EU-Language";
            // 
            // rbPL
            // 
            this.rbPL.AutoSize = true;
            this.rbPL.Location = new System.Drawing.Point(6, 111);
            this.rbPL.Name = "rbPL";
            this.rbPL.Size = new System.Drawing.Size(52, 17);
            this.rbPL.TabIndex = 4;
            this.rbPL.Text = "pl_PL";
            this.rbPL.UseVisualStyleBackColor = true;
            this.rbPL.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // rbES
            // 
            this.rbES.AutoSize = true;
            this.rbES.Location = new System.Drawing.Point(6, 88);
            this.rbES.Name = "rbES";
            this.rbES.Size = new System.Drawing.Size(56, 17);
            this.rbES.TabIndex = 3;
            this.rbES.Text = "es_ES";
            this.rbES.UseVisualStyleBackColor = true;
            this.rbES.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // rbFR
            // 
            this.rbFR.AutoSize = true;
            this.rbFR.Location = new System.Drawing.Point(6, 65);
            this.rbFR.Name = "rbFR";
            this.rbFR.Size = new System.Drawing.Size(51, 17);
            this.rbFR.TabIndex = 2;
            this.rbFR.Text = "fr_FR";
            this.rbFR.UseVisualStyleBackColor = true;
            this.rbFR.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // rbDE
            // 
            this.rbDE.AutoSize = true;
            this.rbDE.Location = new System.Drawing.Point(6, 42);
            this.rbDE.Name = "rbDE";
            this.rbDE.Size = new System.Drawing.Size(58, 17);
            this.rbDE.TabIndex = 1;
            this.rbDE.Text = "de_DE";
            this.rbDE.UseVisualStyleBackColor = true;
            this.rbDE.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // rbEN
            // 
            this.rbEN.AutoSize = true;
            this.rbEN.Checked = true;
            this.rbEN.Location = new System.Drawing.Point(6, 19);
            this.rbEN.Name = "rbEN";
            this.rbEN.Size = new System.Drawing.Size(58, 17);
            this.rbEN.TabIndex = 0;
            this.rbEN.TabStop = true;
            this.rbEN.Text = "en_GB";
            this.rbEN.UseVisualStyleBackColor = true;
            this.rbEN.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.rtbAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(336, 296);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // rtbAbout
            // 
            this.rtbAbout.BackColor = System.Drawing.Color.White;
            this.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAbout.Location = new System.Drawing.Point(8, 245);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.ReadOnly = true;
            this.rtbAbout.Size = new System.Drawing.Size(153, 43);
            this.rtbAbout.TabIndex = 0;
            this.rtbAbout.Text = "LoL-Starter v1.0\n\nCopyRight © Jeroen Buyssens";
            // 
            // LoLStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 322);
            this.Controls.Add(this.Servers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "LoLStarter";
            this.Text = "LoL-Starter";
            this.Load += new System.EventHandler(this.LoLStarter_Load);
            this.Servers.ResumeLayout(false);
            this.tabServers.ResumeLayout(false);
            this.gbUS.ResumeLayout(false);
            this.gbEU.ResumeLayout(false);
            this.gbEU.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.gbEULang.ResumeLayout(false);
            this.gbEULang.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Servers;
        private System.Windows.Forms.TabPage tabServers;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.RichTextBox rtbAbout;
        private System.Windows.Forms.GroupBox gbEULang;
        private System.Windows.Forms.RadioButton rbPL;
        private System.Windows.Forms.RadioButton rbES;
        private System.Windows.Forms.RadioButton rbFR;
        private System.Windows.Forms.RadioButton rbDE;
        private System.Windows.Forms.RadioButton rbEN;
        private System.Windows.Forms.GroupBox gbUS;
        private System.Windows.Forms.Button btnUS;
        private System.Windows.Forms.GroupBox gbEU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEU;
        private System.Windows.Forms.ToolTip ttLang;
        private System.Windows.Forms.Label lbCurLang;
    }
}

