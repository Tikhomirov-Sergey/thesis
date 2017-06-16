﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class ErrorMessage : ApplicationException
    {
        private static bool globalError = false;

        public ErrorMessage() { }

        public ErrorMessage(string message) : base(message)
        {
            MessageBox.Show(message, "Ошибка");

            globalError = true;
        }

        public static bool getGlobalError()
        {
            return globalError;
        }

        public static void changeGlobalError()
        {
            globalError = !(globalError);
        }

        public ErrorMessage(string message, Exception inner) : base(message, inner) { }
    }
}
