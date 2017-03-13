using System;


namespace WindowsFormsApplication8
{
    class CheckString
    {
        static public void checkStringWithDouble(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | (e.KeyChar == '\b'))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
