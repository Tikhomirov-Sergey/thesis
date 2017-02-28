using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStuctures.InaccuracyOfPositioningPart
{
   public class Instrument
    {
        public string instrument { get; set; }
        public Surface[] surfaces { get; set; }

        public string getInstrument()
        {
            return instrument;
        }
    }
}
