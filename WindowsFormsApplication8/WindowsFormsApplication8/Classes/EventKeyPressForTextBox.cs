using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventKeyPressForTextBox
    {
        public static void keyPressForTextBoxWithDouble(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.')
            {
                e.KeyChar = ',';
                keyPressForTextBoxWithDouble(sender, e);
            }
            CheckString.checkStringWithDouble(e);
        }
    }
}
