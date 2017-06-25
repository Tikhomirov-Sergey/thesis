using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class ParametersOfSurface
    {
        private double lengthOfPart;
        private double diameterOfPart;

        private TypeOfPart typeOfPart;
        private TypeOfPart typeOfAllowance;
        private TypeOfPart typeOfProcessedSurface;

        private double surfaceRoughnessRz;
        private double allowance;
        private double holeDepth;

        public ParametersOfSurface(double diameterOfPart,
            TypeOfPart typeOfPart, TypeOfPart typeOfAllowance, TypeOfPart typeOfProcessedSurface,
            double surfaceRoughnessRa, double allowance, double holeDepth = 0)
        {
            this.diameterOfPart = diameterOfPart;
            this.typeOfPart = typeOfPart;
            this.typeOfAllowance = typeOfAllowance;
            this.typeOfProcessedSurface = typeOfProcessedSurface;
            this.surfaceRoughnessRz = ConversionRoughnessRzAndRa.RaToRz(surfaceRoughnessRa);
            this.allowance = allowance;
            this.holeDepth = holeDepth;
        }

        public ParametersOfSurface()
        {
            this.diameterOfPart = 0;
            this.typeOfPart = new TypeOfPart("", 0);
            this.typeOfAllowance = new TypeOfPart("", 0); 
            this.typeOfProcessedSurface = new TypeOfPart("", 0); 
            this.surfaceRoughnessRz = 0;
            this.allowance = 0;
            this.holeDepth = 0;
        }

        public void insertParametersOfPartInTextboxes(MainForm form)
        {
            form.DiameterOfPart.Text = this.diameterOfPart.ToString();

            form.TypeOfPart.SelectedIndex = this.typeOfPart.getIndex();
            form.TypeOfAllowance.SelectedIndex = this.typeOfAllowance.getIndex();
            form.TypeOfProcessedSurface.SelectedIndex = this.typeOfProcessedSurface.getIndex();

            form.SurfaceRoughness.Text = ConversionRoughnessRzAndRa.RzToRa(this.surfaceRoughnessRz).ToString();
            form.Allowance.Text = this.allowance.ToString();
            form.HoleDepth.Text = this.holeDepth.ToString();
        }

        public double getLengthOfPart()
        {
            return this.lengthOfPart;
        }

        public void setLengthOfPart(double lengthOfPart)
        {
            this.lengthOfPart = lengthOfPart;
        }

        public double getDiameterOfPart()
        {
            return this.diameterOfPart;
        }

        public void setDiameterOfPart(double diameterOfPart)
        {
            this.diameterOfPart = diameterOfPart;
        }


        public TypeOfPart getTypeOfPart()
        {
            return this.typeOfPart;
        }
        

        public void setTypeOfPart(TypeOfPart typeOfPart)
        {
            this.typeOfPart = typeOfPart;
        }
        public void setTypeOfPart(string name, int index)
        {
            TypeOfPart typeOfPart = new TypeOfPart(name, index);
            this.typeOfPart = typeOfPart;
        }

        public TypeOfPart getTypeOfAllowance()
        {
            return this.typeOfAllowance;
        }

        public void setTypeOfAllowance(TypeOfPart typeOfAllowance)
        {
            this.typeOfAllowance = typeOfAllowance;
        }

        public void setTypeOfAllowance(string name, int index)
        {
            TypeOfPart typeOfAllowance = new TypeOfPart(name, index);
            this.typeOfAllowance = typeOfAllowance;
        }

        public TypeOfPart getTypeOfProcessedSurface()
        {
            return this.typeOfProcessedSurface;
        }

        public void setTypeOfProcessedSurface(TypeOfPart typeOfProcessedSurface)
        {
            this.typeOfProcessedSurface = typeOfProcessedSurface;
        }

        public void setTypeOfProcessedSurface(string name, int index)
        {
            TypeOfPart typeOfProcessedSurface = new TypeOfPart(name, index);
            this.typeOfProcessedSurface = typeOfProcessedSurface;
        }

        public double getHoleDepth()
        {
            return this.holeDepth;
        }

        public void setHoleDepth(double holeDepth)
        {
            this.holeDepth = holeDepth;
        }

        public double getAllowance()
        {
            return this.allowance;
        }

        public void setAllowance(double allowance)
        {
            this.allowance = allowance;
        }

        public double getSurfaceRoughnessRz()
        {
            return surfaceRoughnessRz;
        }

        public void setSurfaceRoughnessRa(double surfaceRoughness)
        {
            this.surfaceRoughnessRz = ConversionRoughnessRzAndRa.RaToRz(surfaceRoughness);
        }
    }
}
