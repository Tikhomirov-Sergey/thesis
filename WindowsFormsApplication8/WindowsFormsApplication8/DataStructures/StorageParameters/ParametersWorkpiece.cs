using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class ParametersWorkpiece
    {
        private string nameOfWorkpiece ="";
        private string idWorkpiece = "";
        private string surfaceRoughnessRz = "";
        private Interval recommendedIntervalRz = null;
        private string kvalitet = "";
        private string thicknessOfDefectiveCoating = "";
        private string validOffsetSurface = "0";
        
        public ParametersWorkpiece(string nameOfWorkpiece, string idWorkpiece, string surfaceRoughnessRz,
            Interval recommendedIntervalRz, string kvalitet, string thicknessOfDefectiveCoating, string validOffsetSurface = "0")
        {
            this.nameOfWorkpiece = nameOfWorkpiece;
            this.idWorkpiece = idWorkpiece;
            this.surfaceRoughnessRz = surfaceRoughnessRz;
            this.recommendedIntervalRz = recommendedIntervalRz;
            this.kvalitet = kvalitet;
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
            this.validOffsetSurface = validOffsetSurface;
        }

        public void insertParametersOfWorkpieceInTextboxes(FormOfSelectWorkpiece form)
        {
            form.NameOfWorkpiece.Text = this.getNameOfWorkpiece();
            form.SurfaceRoughnessRz.Text = this.getSurfaceRoughnessRz();
            form.ThicknessOfDefectiveCoating.Text = this.getThicknessOfDefectiveCoating();
            form.Kvalitet.Text = this.getKvalitet();

            string idWorkpieceStr = this.getIdWorkpiece();
            int idWorkpiece = Convert.ToInt32(idWorkpieceStr);
            if ((idWorkpiece == 2) || (idWorkpiece == 3))
            {
                form.ValidOffsetSurface.Enabled = true;
                form.label4.Enabled = true;
                form.label5.Enabled = true;
            }
            else
            {
                form.ValidOffsetSurface.Enabled = false;
                form.label4.Enabled = false;
                form.label5.Enabled = false;
            }
        }

        public void setNameOfWorkpiece(string nameOfWorkpiece)
        {
            this.nameOfWorkpiece = nameOfWorkpiece;
        }
        public string getNameOfWorkpiece()
        {
            return this.nameOfWorkpiece;
        }
        
        public void setSurfaceRoughnessRz(string surfaceRoughnessRz)
        {
            this.surfaceRoughnessRz = surfaceRoughnessRz;
        }
        public string getSurfaceRoughnessRz()
        {
            return this.surfaceRoughnessRz;
        }
        public double getSurfaceRoughnessRzToDouble()
        {
            return Convert.ToDouble(this.surfaceRoughnessRz);
        }

        public void setIdWorkpiece(string idWorkpiece)
        {
            this.idWorkpiece = idWorkpiece;
        }
        public string getIdWorkpiece()
        {
            return this.idWorkpiece;
        }
        public int getIdWorkpieceToInt()
        {
            return Convert.ToInt32(this.idWorkpiece);
        }

        public void setKvalitet(string kvalitet)
        {
            this.kvalitet = kvalitet;
        }
        public string getKvalitet()
        {
            return this.kvalitet;
        }
        public double getKvalitetToDouble()
        {
            return Convert.ToDouble(this.kvalitet);
        }

        public void setThicknessOfDefectiveCoating(string thicknessOfDefectiveCoating)
        {
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
        }
        public string getThicknessOfDefectiveCoating()
        {
            return this.thicknessOfDefectiveCoating;
        }
        public double getThicknessOfDefectiveCoatingToDouble()
        {
            return Convert.ToDouble(this.thicknessOfDefectiveCoating);
        }

        public void setValidOffsetSurface(string validOffsetSurface)
        {
            this.validOffsetSurface = validOffsetSurface;
        }
        public string getValidOffsetSurface()
        {
            return this.validOffsetSurface;
        }
        public double getValidOffsetSurfaceToDouble()
        {
            return Convert.ToDouble(this.validOffsetSurface);
        }

        public void setRecommendedIntervalRz(Interval interval)
        {
            this.recommendedIntervalRz = interval;
        }
        public Interval getRecommendedIntervalRz()
        {
            return this.recommendedIntervalRz;
        }
    }
}
