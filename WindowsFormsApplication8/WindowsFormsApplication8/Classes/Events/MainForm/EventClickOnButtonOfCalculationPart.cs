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
            try {
                ParametersOfPart parameters = extractionOfParametersOfPartFromTextBoxes(form);
                Part.setParametersOfPart(parameters);
                Part.calculationOfSurfaces();
            }
            catch { }
        }

    public static ParametersOfPart extractionOfParametersOfPartFromTextBoxes(MainForm form)
        {
            double lengthOfPart = Convert.ToDouble(form.LengthOfPart.Text);
            double diameterOfPart = Convert.ToDouble(form.DiameterOfPart.Text);

            int typeOfPart = form.TypeOfPart.SelectedIndex;
            int typeOfAllowance = form.TypeOfAllowance.SelectedIndex;
            int typeOfProcessedSurface = form.TypeOfProcessedSurface.SelectedIndex;

            double allowance = Convert.ToDouble(form.Allowance.Text);
            double holeDepth = Convert.ToDouble(form.HoleDepth.Text);

            ParametersOfPart parameters = new ParametersOfPart(lengthOfPart, diameterOfPart,typeOfPart, typeOfAllowance, typeOfProcessedSurface, allowance, holeDepth);
            return parameters;
    }

    }
}
