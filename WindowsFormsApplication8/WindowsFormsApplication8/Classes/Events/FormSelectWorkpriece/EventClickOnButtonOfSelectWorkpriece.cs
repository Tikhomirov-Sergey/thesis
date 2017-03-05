using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.FormSelectWorkpriece
{
    class EventClickOnButtonOfSelectWorkpriece
    {
        public static void buttonSelectWorkpriece(FormOfSelectWorkpiece form)
        {
            string nameOfWorkpiece = form.NameOfWorkpiece.Text;
            string surfaceRoughnessRz = form.SurfaceRoughnessRz.Text;
            string kvalitet = form.Kvalitet.Text;
            string thicknessOfDefectiveCoating = form.ThicknessOfDefectiveCoating.Text;
            double validOffsetSurface = Convert.ToDouble(form.ValidOffsetSurface.Text);

            ParametersWorkpiece parameters = Part.getWorkpiece();

            parameters.setNameOfWorkpiece(nameOfWorkpiece);
            parameters.setSurfaceRoughnessRz(surfaceRoughnessRz);
            parameters.setKvalitet(kvalitet);
            parameters.setThicknessOfDefectiveCoating(thicknessOfDefectiveCoating);
            parameters.setValidOffsetSurface(validOffsetSurface);
        }
    }
}
