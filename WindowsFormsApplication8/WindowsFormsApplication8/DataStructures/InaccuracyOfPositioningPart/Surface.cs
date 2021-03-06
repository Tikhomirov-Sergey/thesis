﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStuctures.InaccuracyOfPositioningPart
{
   public class Surface
    {
        public int[] id { get; set; }
        public IntervalsAndDeviationOfInstallation[] intervalsAndDeviationOfInstallation { get; set; }


        public bool checkOfIdOperation(int idOperation)
        {
            bool isSelectedIdOperation = false;

            foreach (int id in this.id)
            {
                if(id == idOperation)
                {
                    isSelectedIdOperation = true;
                }
            }
            return isSelectedIdOperation;
        }

        public double getDeviationOfInstallation(double requiredSize)
        {
            double deviationOfInstallation = 0;
            bool chekInterval = false;

            foreach (IntervalsAndDeviationOfInstallation intervalsAndDeviationOfInstallation in this.intervalsAndDeviationOfInstallation)
            {
                if (intervalsAndDeviationOfInstallation.chekInterval(requiredSize))
                {
                    chekInterval = true;
                    deviationOfInstallation = intervalsAndDeviationOfInstallation.getDeviationOfInstallation();
                }
            }

            if (!chekInterval)
            {
                throw new ErrorMessage("Введенный размер выходит за границы таблицы");
            }

            return deviationOfInstallation;
        }
    }
}

