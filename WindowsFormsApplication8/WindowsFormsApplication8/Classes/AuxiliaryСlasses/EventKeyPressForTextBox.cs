using System.Windows.Forms;
using System;

namespace WindowsFormsApplication8
{
    class EventKeyPressForTextBox
    {
        public static void keyPressForTextBoxWithDouble(object sender, KeyPressEventArgs e)
        {
            try {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                    keyPressForTextBoxWithDouble(sender, e);
                }
                CheckString.checkStringWithDouble(e);
             }
            catch { }
        }
    }
}
