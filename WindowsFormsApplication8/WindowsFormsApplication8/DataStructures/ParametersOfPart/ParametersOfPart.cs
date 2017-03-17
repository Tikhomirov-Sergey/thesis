using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class ParametersOfPart
    {
        private double lengthOfPart;
        private double diameterOfPart;

        private int typeOfPart;
        private int typeOfAllowance;
        private int typeOfProcessedSurface;

        private double allowance;
        private double holeDepth;

        public ParametersOfPart(double lengthOfPart, double diameterOfPart,
            int typeOfPart, int typeOfAllowance, int typeOfProcessedSurface,
            double allowance, double holeDepth = 0)
        {
            this.lengthOfPart = lengthOfPart;
            this.diameterOfPart = diameterOfPart;
            this.typeOfPart = typeOfPart;
            this.typeOfAllowance = typeOfAllowance;
            this.typeOfProcessedSurface = typeOfProcessedSurface;
            this.allowance = allowance;
            this.holeDepth = holeDepth;
        }

        public void insertParametersOfPartInTextboxes(MainForm form)
        {
            form.LengthOfPart.Text = this.lengthOfPart.ToString();
            form.DiameterOfPart.Text = this.diameterOfPart.ToString();

            form.TypeOfPart.SelectedIndex = this.typeOfPart;
            form.TypeOfAllowance.SelectedIndex = this.typeOfAllowance;
            form.TypeOfProcessedSurface.SelectedIndex = this.typeOfProcessedSurface;

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

        public int getTypeOfPart()
        {
            return this.typeOfPart;
        }

        public void setTypeOfPart(int typeOfPart)
        {
            this.typeOfPart = typeOfPart;
        }

        public int getTypeOfAllowance()
        {
            return this.typeOfAllowance;
        }

        public void setTypeOfAllowance(int typeOfAllowance)
        {
            this.typeOfAllowance = typeOfAllowance;
        }

        public int getTypeOfProcessedSurface()
        {
            return this.typeOfProcessedSurface;
        }

        public void setTypeOfProcessedSurface(int typeOfProcessedSurface)
        {
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
    }
}
