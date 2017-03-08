using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStuctures.InaccuracyOfPositioningPart
{
   public class Instrument
    {
        public string instrument { get; set; }
        public bool usedSizeIsDiameter { get; set; }
        public Surface[] surfaces { get; set; }

        public string getInstrument()
        {
            return instrument;
        }

        public bool getUsedSizeIsDiameter()
        {
            return this.usedSizeIsDiameter;
        }

        public bool isSelectedInstrument(string typeOfInstrument)
        {
            return this.instrument.Equals(typeOfInstrument);
        }

        public double getDeviationOfInstallation(double requiredSize, int idOperation)
        {
            double deviationOfInstallation = 0;

            foreach (Surface surface in surfaces)
            {
                if (surface.checkOfIdOperation(idOperation))
                {
                    deviationOfInstallation = surface.getDeviationOfInstallation(requiredSize);
                }
            }

            return deviationOfInstallation;
        }
    }
}
