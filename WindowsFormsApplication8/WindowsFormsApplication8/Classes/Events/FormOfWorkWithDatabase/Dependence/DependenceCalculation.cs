using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class DependenceCalculation
    {
        private int id;
        private string date;

        public DependenceCalculation(int id, string date)
        {
            this.id = id;
            this.date = date;
        }

        public int getId()
        {
            return id;
        }

        public string getDate()
        {
            return date;
        }
    }
}
