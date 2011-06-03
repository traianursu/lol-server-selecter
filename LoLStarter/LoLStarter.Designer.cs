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
            this.Servers = new System.Windows.Forms.TabControl();
            this.tabServers = new System.Windows.Forms.TabPage();
            this.gbUS = new System.Windows.Forms.GroupBox();
            this.btnUS = new System.Windows.Forms.Button();
            this.gbEU = new System.Windows.Forms.GroupBox();
            this.lbCurLang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEU = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ttLang = new System.Windows.Forms.ToolTip(this.components);
            this.Servers.SuspendLayout();
            this.tabServers.SuspendLayout();
            this.gbUS.SuspendLayout();
            this.gbEU.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(336, 296);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EU-Language";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 111);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(52, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "pl_PL";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "es_ES";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "fr_FR";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "de_DE";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "en_GB";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.richTextBox1);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(336, 296);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(8, 245);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(153, 43);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "LoL-Starter v1.0\n\nCopyRight © Jeroen Buyssens";
            // 
            // LoLStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 322);
            this.Controls.Add(this.Servers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "LoLStarter";
            this.Text = "LoL-Starter";
            this.Load += new System.EventHandler(this.LoLStarter_Load_1);
            this.Servers.ResumeLayout(false);
            this.tabServers.ResumeLayout(false);
            this.gbUS.ResumeLayout(false);
            this.gbEU.ResumeLayout(false);
            this.gbEU.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Servers;
        private System.Windows.Forms.TabPage tabServers;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gbUS;
        private System.Windows.Forms.Button btnUS;
        private System.Windows.Forms.GroupBox gbEU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEU;
        private System.Windows.Forms.ToolTip ttLang;
        private System.Windows.Forms.Label lbCurLang;
    }
}

