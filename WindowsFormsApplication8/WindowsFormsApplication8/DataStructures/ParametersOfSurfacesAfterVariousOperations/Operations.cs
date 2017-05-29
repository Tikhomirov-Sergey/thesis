using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.ParametersOfSurfacesAfterVariousOperations
{
    public class Operations
    {
        public string typeOfMachining { get; set; }
        public PrecisionOfMachining[] precisionOfMachining { get; set; }

        public string getTypeOfMachining()
        {
            return typeOfMachining;
        }

        public List<ParametersOperation> getListOperationOnSurfaceRoughness(double surfaceRoughness, string nameOperation, string typeOfInstrument)
        {
            int indextPrecisionOfMachining = checkSurfaceRoughness(surfaceRoughness);

            List<ParametersOperation> operations = new List<ParametersOperation>();

            for(int i = 0; i <= indextPrecisionOfMachining; i++)
            {
                ParametersOperation parameters = precisionOfMachining[i].getParametersOperation(nameOperation);
                parameters.setTypeOfInstrument(typeOfInstrument);

                operations.Add(parameters);
            }

            return operations;
        }

        private int checkSurfaceRoughness(double surfaceRoughness)
        {
            int countPrecisionOfMachining = precisionOfMachining.Length;

            int indextPrecisionOfMachining = 0;

            for(int i = 0; i < countPrecisionOfMachining; i++)
            {
                if (precisionOfMachining[i].checkInterval(surfaceRoughness))
                {
                    indextPrecisionOfMachining = i;
                }
            }

            return indextPrecisionOfMachining;
        }
    }
}
