using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class ParametersWorkpiece
    {
        private string nameOfWorkpiece;
        private int idWorkpiece;
        private double surfaceRoughnessRz;
        private Interval recommendedIntervalRz;
        private int kvalitet;
        private double thicknessOfDefectiveCoating;
        private double validOffsetSurface;
        
        public ParametersWorkpiece(string nameOfWorkpiece, int idWorkpiece, double surfaceRoughnessRz,
            Interval recommendedIntervalRz, int kvalitet, double thicknessOfDefectiveCoating, double validOffsetSurface = 0)
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
            form.SurfaceRoughnessRz.Text = this.getSurfaceRoughnessRzToString();
            form.ThicknessOfDefectiveCoating.Text = this.getThicknessOfDefectiveCoatingToString();
            form.Kvalitet.Text = this.getKvalitetToString();

            string idWorkpieceStr = this.getIdWorkpieceToString();
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

        public void insertNameOfWorkpieceInTreeViewAndTextBox(MainForm form)
        {
            if (form.TreeOfSelectedOperations.Nodes.Count == 0)
            {
                form.TreeOfSelectedOperations.Nodes.Add(this.nameOfWorkpiece);
            }
            else
            {
                form.TreeOfSelectedOperations.Nodes[0].Text = this.nameOfWorkpiece;
            }
            form.NameOfWorkpiece.Text = this.nameOfWorkpiece;
        }

        public void setNameOfWorkpiece(string nameOfWorkpiece)
        {
            this.nameOfWorkpiece = nameOfWorkpiece;
        }
        public string getNameOfWorkpiece()
        {
            return this.nameOfWorkpiece;
        }
        
        public void setSurfaceRoughnessRz(double surfaceRoughnessRz)
        {
            this.surfaceRoughnessRz = surfaceRoughnessRz;
        }
        public void setSurfaceRoughnessRz(string surfaceRoughnessRz)
        {
            this.surfaceRoughnessRz = Convert.ToDouble(surfaceRoughnessRz);
        }
        public double getSurfaceRoughnessRz()
        {
            return this.surfaceRoughnessRz;
        }
        public string getSurfaceRoughnessRzToString()
        {
            return Convert.ToString(this.surfaceRoughnessRz);
        }

        public void setIdWorkpiece(int idWorkpiece)
        {
            this.idWorkpiece = idWorkpiece;
        }
        public void setIdWorkpiece(string idWorkpiece)
        {
            this.idWorkpiece = Convert.ToInt32(idWorkpiece);
        }
        public int getIdWorkpiece()
        {
            return this.idWorkpiece;
        }
        public string getIdWorkpieceToString()
        {
            return Convert.ToString(this.idWorkpiece);
        }

        public void setKvalitet(int kvalitet)
        {
            this.kvalitet = kvalitet;
        }
        public void setKvalitet(string kvalitet)
        {
            this.kvalitet = Convert.ToInt32(kvalitet);
        }
        public int getKvalitet()
        {
            return this.kvalitet;
        }
        public string getKvalitetToString()
        {
            return Convert.ToString(this.kvalitet);
        }

        public void setThicknessOfDefectiveCoating(double thicknessOfDefectiveCoating)
        {
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
        }
        public void setThicknessOfDefectiveCoating(string thicknessOfDefectiveCoating)
        {
            this.thicknessOfDefectiveCoating = Convert.ToDouble(thicknessOfDefectiveCoating);
        }
        public double getThicknessOfDefectiveCoating()
        {
            return this.thicknessOfDefectiveCoating;
        }
        public string getThicknessOfDefectiveCoatingToString()
        {
            return Convert.ToString(this.thicknessOfDefectiveCoating);
        }

        public void setValidOffsetSurface(double validOffsetSurface)
        {
            this.validOffsetSurface = validOffsetSurface;
        }
        public void setValidOffsetSurface(string validOffsetSurface)
        {
            this.validOffsetSurface = Convert.ToDouble(validOffsetSurface);
        }
        public double getValidOffsetSurface()
        {
            return this.validOffsetSurface;
        }
        public string getValidOffsetSurfaceToDouble()
        {
            return Convert.ToString(this.validOffsetSurface);
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
