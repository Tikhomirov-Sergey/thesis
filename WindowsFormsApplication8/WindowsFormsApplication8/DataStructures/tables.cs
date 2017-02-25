using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class tables
    {
        protected static InaccuracyOfPositioningPart inaccuracyOfPositioningPart = null;

        public static InaccuracyOfPositioningPart getInaccuracyOfPositioningPart()
        {
            if(inaccuracyOfPositioningPart == null)
            {
                inaccuracyOfPositioningPart = new InaccuracyOfPositioningPart();
                inaccuracyOfPositioningPart = (InaccuracyOfPositioningPart)XMLtoObject.inaccuracyOfPositioningPartFromXML(@"XMLFiles/InaccuracyOfPositioningPart.json", inaccuracyOfPositioningPart);
            }
            return inaccuracyOfPositioningPart;
        }

    }
}
