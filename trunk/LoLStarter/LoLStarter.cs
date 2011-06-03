using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoLStarter
{
    public partial class LoLStarter : Form
    {
        public LoLStarter()
        {
            InitializeComponent();
        }

        private void LoLStarter_Load(object sender, EventArgs e)
        {
            ttLang.SetToolTip(lbCurLang, "You can change the preferred language in the settings tab.");
            lbCurLang.Text = gbEULang.SelectedRadioButton().Text;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            lbCurLang.Text = gbEULang.SelectedRadioButton().Text;
        }
    }

    public static class Extensions
    {
        public static RadioButton SelectedRadioButton(this GroupBox g)
        {
            return g.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault();
        }
    }
}
