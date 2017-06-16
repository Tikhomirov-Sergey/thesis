using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfCalculationPart
    {
        public static void buttonOfCalculation(MainForm form)
        {
            try
            {

                ParametersOfSurface parameters = extractionOfParametersOfPartFromTextBoxes(form);
                Part.setParametersOfPart(parameters);
                Part.calculationOfSurfaces();

                if (Part.getSurfaceOnIndex(1).getParametersOperation()[0] != null && !ErrorMessage.getGlobalError())
                {
                    FormResult formResult = new FormResult();
                    formResult.ShowDialog();
                }
            }
            catch { }
        }

        public static ParametersOfSurface extractionOfParametersOfPartFromTextBoxes(MainForm form)
        {
            double lengthOfPart = StringConvertToDoubleOrZero(form.LengthOfPart.Text);
            double diameterOfPart = StringConvertToDoubleOrZero(form.DiameterOfPart.Text);

            TypeOfPart typeOfPart = createType(form.TypeOfPart);
            TypeOfPart typeOfAllowance = createType(form.TypeOfAllowance);
            TypeOfPart typeOfProcessedSurface = createType(form.TypeOfProcessedSurface);

            double surfaceRoughness = StringConvertToDoubleOrZero(form.SurfaceRoughness.Text);
            double allowance = StringConvertToDoubleOrZero(form.Allowance.Text);
            double holeDepth = StringConvertToDoubleOrZero(form.HoleDepth.Text);


            ParametersOfSurface parameters = new ParametersOfSurface(lengthOfPart, diameterOfPart,typeOfPart, typeOfAllowance, typeOfProcessedSurface, surfaceRoughness, allowance, holeDepth);
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

        private static TypeOfPart createType(ComboBox comboBox)
        {
            string name = comboBox.Text;
            int index = comboBox.SelectedIndex;

            TypeOfPart typeOfPart = new TypeOfPart(name, index);

            return typeOfPart;
        }



    }
}
