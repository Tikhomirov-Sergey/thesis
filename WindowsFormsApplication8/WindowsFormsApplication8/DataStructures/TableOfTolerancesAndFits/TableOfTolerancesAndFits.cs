using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class TableOfTolerancesAndFits
    {
        public DataStructures.TableOfTolerancesAndFits.Kvalitet[] kvalitets { get; set; }

        public double getAccuracy(double requiredKvalitet, double requiredSize)
        {
            foreach (DataStructures.TableOfTolerancesAndFits.Kvalitet kvalitet in kvalitets)
            {
                if (kvalitet.checkKvalitet(requiredKvalitet))
                {
                    return kvalitet.getTolerance(requiredSize);
                }
            }
            return 0;
        }
    }
}
