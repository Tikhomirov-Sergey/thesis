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

        private double surfaceRoughness;
        private double allowance;
        private double holeDepth;

        public ParametersOfSurface(double diameterOfPart,
            TypeOfPart typeOfPart, TypeOfPart typeOfAllowance, TypeOfPart typeOfProcessedSurface,
            double surfaceRoughness, double allowance, double holeDepth = 0)
        {
            this.diameterOfPart = diameterOfPart;
            this.typeOfPart = typeOfPart;
            this.typeOfAllowance = typeOfAllowance;
            this.typeOfProcessedSurface = typeOfProcessedSurface;
            this.surfaceRoughness = surfaceRoughness;
            this.allowance = allowance;
            this.holeDepth = holeDepth;
        }

        public void insertParametersOfPartInTextboxes(MainForm form)
        {
            form.DiameterOfPart.Text = this.diameterOfPart.ToString();

            form.TypeOfPart.SelectedIndex = this.typeOfPart.getIndex();
            form.TypeOfAllowance.SelectedIndex = this.typeOfAllowance.getIndex();
            form.TypeOfProcessedSurface.SelectedIndex = this.typeOfProcessedSurface.getIndex();

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

        public double getSurfaceRoughness()
        {
            return surfaceRoughness;
        }

        public void setSurfaceRoughness(double surfaceRoughness)
        {
            this.surfaceRoughness = surfaceRoughness;
        }
    }
}
