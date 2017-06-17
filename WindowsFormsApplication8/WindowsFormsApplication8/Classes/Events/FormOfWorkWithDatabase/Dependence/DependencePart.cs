using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class DependencePart
    {
        private int id;
        private string name;
        private double lengthPart;

        public DependencePart(int id, string name, double lengthPart)
        {
           this.id = id;
           this.name = name;
           this.lengthPart = lengthPart;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
           return name;
        }

        public double getLengthPart()
        {
            return lengthPart;
        }
        
    }
}
