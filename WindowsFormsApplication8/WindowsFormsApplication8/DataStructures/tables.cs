using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Tables
    {
        protected static InaccuracyOfPositioningPart inaccuracyOfPositioningPart = null;

        public static InaccuracyOfPositioningPart getInaccuracyOfPositioningPart()
        {
            if(inaccuracyOfPositioningPart == null)
            {
                inaccuracyOfPositioningPart = new InaccuracyOfPositioningPart();
                inaccuracyOfPositioningPart = (InaccuracyOfPositioningPart)XMLtoObject.inaccuracyOfPositioningPartFromXML(@"XMLFiles/InaccuracyOfPositioningPart.xml", inaccuracyOfPositioningPart);
            }
            return inaccuracyOfPositioningPart;
        }

    }
}
