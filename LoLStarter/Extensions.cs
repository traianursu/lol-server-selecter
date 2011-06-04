using System;
using System.Linq;
using System.Windows.Forms;

namespace LoLStarter
{
    public static class Extensions
    {
        public static RadioButton SelectedRadioButton(this GroupBox g)
        {
            return g.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault();
        }
    }
}
