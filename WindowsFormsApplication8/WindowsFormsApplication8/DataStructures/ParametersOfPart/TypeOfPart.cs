using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class TypeOfPart
    {
        private string name;
        private int index;

        public TypeOfPart(string name, int index)
        {
            this.name = name;
            this.index = index;
        }

        public string getName()
        {
            return this.name;
        }

        public int getIndex()
        {
            return this.index;
        }

        public void setType(string name, int index)
        {
            this.name = name;
            this.index = index;
        }
    }
}
