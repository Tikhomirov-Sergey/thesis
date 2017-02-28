using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class InaccuracyOfPositioningPart
    {
        public DataStuctures.InaccuracyOfPositioningPart.Instrument[] instruments { get; set; }


        public string[] getListInstruments()
        {
            int lengthListInstruments = instruments.Length;
            string[] listInstruments = new string[lengthListInstruments];

            for(int i = 0; i < lengthListInstruments; i++)
            {
                listInstruments[i] = instruments[i].getInstrument();
            }
            return listInstruments;
        }
    }
}
