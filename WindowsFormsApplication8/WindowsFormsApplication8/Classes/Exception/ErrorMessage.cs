using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class ErrorMessage : ApplicationException
    {
        public ErrorMessage() { }

        public ErrorMessage(string message) : base(message)
        {
            MessageBox.Show(message, "Ошибка");
        }

        public ErrorMessage(string message, Exception inner) : base(message, inner) { }
    }
}
