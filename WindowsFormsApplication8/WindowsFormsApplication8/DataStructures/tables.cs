using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Tables
    {
        private static InaccuracyOfPositioningPart inaccuracyOfPositioningPart = null;
        private static TableOfTolerancesAndFits tableOfTolerancesAndFits = null;

        public static InaccuracyOfPositioningPart getInaccuracyOfPositioningPart()
        {
            if(inaccuracyOfPositioningPart == null)
            {
                inaccuracyOfPositioningPart = new InaccuracyOfPositioningPart();
                inaccuracyOfPositioningPart = (InaccuracyOfPositioningPart)XMLtoObject.objectFromXML(@"XMLFiles/InaccuracyOfPositioningPart.xml", inaccuracyOfPositioningPart);
            }
            return inaccuracyOfPositioningPart;
        }

        public static TableOfTolerancesAndFits getTableOfTolerancesAndFits()
        {
            if (tableOfTolerancesAndFits == null)
            {
                tableOfTolerancesAndFits = new TableOfTolerancesAndFits();
                tableOfTolerancesAndFits = (TableOfTolerancesAndFits)XMLtoObject.objectFromXML(@"XMLFiles/TableOfTolerancesAndFits.xml", tableOfTolerancesAndFits);
            }
            return tableOfTolerancesAndFits;
        }
    }
}
