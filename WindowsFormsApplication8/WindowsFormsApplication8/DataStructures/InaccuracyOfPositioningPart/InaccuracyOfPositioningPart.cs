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

        public double getDeviationOfInstallation(double requiredSize, int idOperation, string typeOfInstrument)
        {
            double deviationOfInstallation = 0;

            foreach (DataStuctures.InaccuracyOfPositioningPart.Instrument instrument in instruments)
            {
                if (instrument.isSelectedInstrument(typeOfInstrument))
                {
                    deviationOfInstallation = instrument.getDeviationOfInstallation(requiredSize, idOperation);
                }
            }

            return deviationOfInstallation;
        }

        public bool usedSizeIsDiameter(string typeOfInstrument)
        {
            bool usedSizeIsDiameter = false;

            foreach (DataStuctures.InaccuracyOfPositioningPart.Instrument instrument in instruments)
            {
                if (instrument.isSelectedInstrument(typeOfInstrument))
                {
                    usedSizeIsDiameter = instrument.getUsedSizeIsDiameter();
                }
            }

            return usedSizeIsDiameter;
        }
    }
}
