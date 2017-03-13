using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfCalculationPart
    {
        public static void buttonOfCalculation(MainForm form)
        {
            ParametersOfPart parameters = extractionOfParametersOfPartFromTextBoxes(form);
            Part.setParametersOfPart(parameters);
            Part.calculationOfSurfaces();
        }

        public static ParametersOfPart extractionOfParametersOfPartFromTextBoxes(MainForm form)
        {
            double lengthOfPart = StringConvertToDoubleOrZero(form.LengthOfPart.Text);
            double diameterOfPart = StringConvertToDoubleOrZero(form.DiameterOfPart.Text);

            int typeOfPart = form.TypeOfPart.SelectedIndex;
            int typeOfAllowance = form.TypeOfAllowance.SelectedIndex;
            int typeOfProcessedSurface = form.TypeOfProcessedSurface.SelectedIndex;
            
            double allowance = StringConvertToDoubleOrZero(form.Allowance.Text);
            double holeDepth = StringConvertToDoubleOrZero(form.HoleDepth.Text);

            ParametersOfPart parameters = new ParametersOfPart(lengthOfPart, diameterOfPart,typeOfPart, typeOfAllowance, typeOfProcessedSurface, allowance, holeDepth);
            return parameters;
        }


        private static double StringConvertToDoubleOrZero(string str)
        {
            double strToDouble;

            try
            {
                strToDouble = Convert.ToDouble(str);
            }
            catch
            {
                strToDouble = 0;
            }

            return strToDouble;
        }



    }
}
