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
        private double validOffsetSurface = 0;
        
        public ParametersWorkpiece(string nameOfWorkpiece, string idWorkpiece, string surfaceRoughnessRz,
            Interval recommendedIntervalRz, string kvalitet, string thicknessOfDefectiveCoating, double validOffsetSurface = 0)
        {
            this.nameOfWorkpiece = nameOfWorkpiece;
            this.idWorkpiece = idWorkpiece;
            this.surfaceRoughnessRz = surfaceRoughnessRz;
            this.recommendedIntervalRz = recommendedIntervalRz;
            this.kvalitet = kvalitet;
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
            this.validOffsetSurface = validOffsetSurface;
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

        public void setIdWorkpiece(string idWorkpiece)
        {
            this.idWorkpiece = idWorkpiece;
        }
        public string getIdWorkpiece()
        {
            return this.idWorkpiece;
        }

        public void setKvalitet(string kvalitet)
        {
            this.kvalitet = kvalitet;
        }
        public string getKvalitet()
        {
            return this.kvalitet;
        }

        public void setThicknessOfDefectiveCoating(string thicknessOfDefectiveCoating)
        {
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
        }
        public string getThicknessOfDefectiveCoating()
        {
            return this.thicknessOfDefectiveCoating;
        }

        public void setValidOffsetSurface(double validOffsetSurface)
        {
            this.validOffsetSurface = validOffsetSurface;
        }
        public double getValidOffsetSurface()
        {
            return this.validOffsetSurface;
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
