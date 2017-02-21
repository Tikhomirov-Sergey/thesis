using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class CheckCommas
    { static public void checkCommas(System.Windows.Forms.TextBox input)

        {
            try
            {
                int lenght = input.Text.Length;
                if (input.Text[lenght - 1].Equals('.')) { input.Text = input.Text.Replace('.', ','); input.SelectionStart = lenght; }

            }
            catch { }

        }
        static public void checkString(System.Windows.Forms.KeyPressEventArgs e)
        { if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;}
    }
}
