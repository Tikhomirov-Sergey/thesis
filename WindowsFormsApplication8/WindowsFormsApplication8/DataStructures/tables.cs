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

        public static string createTable(int[,] size, double[] kvalitet, double[,] table)
        {
            string json = "{" + '"' + "kvalitets" + '"' + ":[";
            
            for (int kvalitetCount = 0; kvalitetCount <= 19; kvalitetCount++)
            {
                json = json + "{" + '"' + "kvalitet" + '"' + ":" + Convert.ToString(kvalitet[kvalitetCount]).Replace(",",".") + "," + '"' + "nominalSizeRangeAndTolerance" + '"' + ":[";
                for (int sizeCount = 0; sizeCount <= 20; sizeCount++)
                {
                    json = json + "{" + '"' + "nominalSizeRang" + '"' + ":{" + '"' + "min" + '"' + ":" + Convert.ToString(size[sizeCount, 0]).Replace(",", ".") + "," + '"' + "max" + '"' + ':' + Convert.ToString(size[sizeCount, 1]).Replace(",", ".") + "}," + '"' + "tolerance" + '"' + ":" + Convert.ToString(table[sizeCount, kvalitetCount]).Replace(",",".") + '}';
                    if(sizeCount != 20)
                    {
                        json = json + ',';
                    }
                }
                json = json + "]}";
                if(kvalitetCount != 19)
                {
                    json = json + ',';
                }
            }
            json = json + "]}";
            return json;
        }

    }
}
