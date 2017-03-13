using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class CurvatureOfImpressionDieForgings
    {
       public DataStructures.CurvatureOfImpressionDieForgings.IntervalAndCoefficient[] intervalAndCoefficient { get; set; }

        public double getCoefficient(double requiredSize)
        {
                double coefficient = 0;
                bool checkOfSize = false;

            foreach (DataStructures.CurvatureOfImpressionDieForgings.IntervalAndCoefficient intervalAndCoefficient in this.intervalAndCoefficient)
            {
                if (intervalAndCoefficient.checkOfSize(requiredSize))
                {
                    checkOfSize = true;
                    coefficient = intervalAndCoefficient.coefficient;
                }   
            }

            if (!checkOfSize)
            {
                throw new ErrorMessage("Введенный размер выходит за границы таблицы");
            }

            return coefficient;
        }
    }
}
