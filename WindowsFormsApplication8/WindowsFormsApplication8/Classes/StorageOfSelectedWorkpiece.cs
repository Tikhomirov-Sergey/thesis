using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class StorageOfSelectedWorkpiece
    {
        private static ParametersWorkpieceFromTreeview parameters = null;

        public static void setParameters(ParametersWorkpieceFromTreeview parametersWorkpiece)
        {
            parameters = parametersWorkpiece;
        }

        public static void insertParametersOfOperationsInTextboxes(Form2 form)
        {
            form.NameOfWorkpiece.Text = parameters.getNameOfWorkpiece();
            form.SurfaceRoughnessRz.Text = parameters.getSurfaceRoughnessRz();
            form.ThicknessOfDefectiveCoating.Text = parameters.getThicknessOfDefectiveCoating();
            form.Kvalitet.Text = parameters.getKvalitet();

            string idWorkpieceStr = parameters.getIdWorkpiece();
            int idWorkpiece = Convert.ToInt32(idWorkpieceStr);
            if ((idWorkpiece == 2) || (idWorkpiece == 3))
            {
                form.ValidOffsetSurface.Enabled = true;
                form.label4.Enabled = true;
                form.label5.Enabled = true;
            } else
            {
                form.ValidOffsetSurface.Enabled = false;
                form.label4.Enabled = false;
                form.label5.Enabled = false;
            }
        }
    }
}
