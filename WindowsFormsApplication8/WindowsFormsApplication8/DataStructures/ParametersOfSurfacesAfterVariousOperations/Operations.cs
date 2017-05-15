using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.ParametersOfSurfacesAfterVariousOperations
{
    public class Operations
    {
        public string typeOfMachining { get; set; }
        public PrecisionOfMachining[] precisionOfMachining { get; set; }

        public string getTypeOfMachining()
        {
            return typeOfMachining;
        }
    }
}
