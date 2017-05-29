﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class Surface
    {
        private string nameSurface = "";
        private List<ParametersOperation> parametersOperation = new List<ParametersOperation>();

        List<Operation> operations = new List<Operation>();

        private ClassesToCalculate.ResultsOfCalculation resultsOfCalculation = null;

        public void setNameSurface(string nameSurface)
        {
            this.nameSurface = nameSurface;
        }

        public string getNameSurface()
        {
            return this.nameSurface;
        }

        public void setOpetation(Operation operation, int indexOfOperation = -1)
        {
            if (indexOfOperation.Equals(-1))
            {
                indexOfOperation = getCountShortListOperation();
            }

           try
           {
                this.operations.Insert(indexOfOperation, operation);
           }
           catch { }
        }

        public List<Operation> getOperations()
        {
            return this.operations;
        }

        public Operation getOperationOnIndex(int indexOperation)
        {
            try
            {
                return operations[indexOperation];
            }
            catch { return null; }
        }

        public string[] getListOperations()
        {
            int length = this.operations.Count;
            string[] list = new string[length];

            for (int i = 0; i < length; i++)
            {
                list[i] = this.operations[i].getTypeOfMachining();
            }

            return list;
        }

        public List<ParametersOperation> getParametersOperation()
        {
            return parametersOperation;
        }

        public int getCountShortListOperation()
        {
            return this.operations.Count;
        }

        public int getCountLongListOperation()
        {
            return this.parametersOperation.Count;
        }

        public void calculationOFSurface()
        {
            ParametersOfPart parametersOfPart = Part.getParametersOfPart();
            DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersOperations = getParametersOperationsForCalculation();

            CalculationOfSurface calculationOfSurface = new CalculationOfSurface(parametersOfPart, parametersOperations);
            this.resultsOfCalculation = calculationOfSurface.calculation();
        }

        private DataStructures.CalculationOfSurface.ParametersOperationsForCalculation getParametersOperationsForCalculation()
        {
            this.formationOfLongListWithParametersOfOperation();

            int countLongListOperation = this.getCountLongListOperation();

            double[] surfaceRoughnessRz = new double[countLongListOperation + 1]; ;
            double[] kvalitets = new double[countLongListOperation + 1]; ;
            double[] thicknessOfDefectiveCoating = new double[countLongListOperation + 1]; ;
            double[] coefficientOfRefinement = new double[countLongListOperation + 1]; ;

            int[] idOperation = new int[countLongListOperation + 1]; ;
            string[] typeOfInstrument = new string[countLongListOperation + 1];

            ParametersWorkpiece workpiece = Part.getWorkpiece();

            surfaceRoughnessRz[0] = workpiece.getSurfaceRoughnessRz();
            kvalitets[0] = workpiece.getKvalitet();
            thicknessOfDefectiveCoating[0] = workpiece.getThicknessOfDefectiveCoating();

            idOperation[0] = workpiece.getIdWorkpiece();

            double validOffsetSurface = workpiece.getValidOffsetSurface();

            for (int i = 0; i < countLongListOperation; i++)
            {
                ParametersOperation operation = this.parametersOperation[i];

                surfaceRoughnessRz[i + 1] = operation.getSurfaceRoughnessRz();
                kvalitets[i + 1] = operation.getKvalitet();
                thicknessOfDefectiveCoating[i + 1] = operation.getThicknessOfDefectiveCoating();
                coefficientOfRefinement[i + 1] = operation.getCoefficientOfRefinement();

                idOperation[i + 1] = operation.getIdOperation();

                typeOfInstrument[i + 1] = operation.getTypeOfInstrument();
            }

            typeOfInstrument = changeTypeOfInstrument(typeOfInstrument);
            
            DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parameters = new DataStructures.CalculationOfSurface.ParametersOperationsForCalculation(surfaceRoughnessRz, kvalitets, thicknessOfDefectiveCoating, coefficientOfRefinement, idOperation, typeOfInstrument, validOffsetSurface);
            return parameters;
        }

        public void formationOfLongListWithParametersOfOperation()
        {
            this.parametersOperation.Clear();

            double surfaceRoughness = Part.getParametersOfPart().getSurfaceRoughness();

            int numberOfOperations = this.getCountShortListOperation();

            for (int i = numberOfOperations - 1; i >= 0; i--)
            {
                Operation operation = this.getOperationOnIndex(i);
                List<ParametersOperation> parametersOperation = Tables.getParametersOfSurfacesAfterVariousOperations().getListOperationOnSurfaceRoughness(operation, surfaceRoughness);

                this.parametersOperation.InsertRange(0, parametersOperation);

                surfaceRoughness = parametersOperation[0].getRecommendedIntervalRz().getIntervalMax();
            }
        }

        public ClassesToCalculate.ResultsOfCalculation getResultsOfCalculation()
        {
            return this.resultsOfCalculation;
        }

        public void insertListOfOperationsInTreeView(MainForm form)
        {
            string[] listOfSurface = this.getListOperations();
            int numberOfOperations = this.getCountShortListOperation();

            for (int i = 1; i <= numberOfOperations; i++)
            {
                if (form.TreeOfSelectedOperations.Nodes.Count <= i)
                {
                    form.TreeOfSelectedOperations.Nodes.Add(listOfSurface[i - 1]);
                }
                else
                {
                    form.TreeOfSelectedOperations.Nodes[i].Text = listOfSurface[i - 1];
                }
            }

            for(int i = numberOfOperations + 1; i < form.TreeOfSelectedOperations.Nodes.Count; i++)
            {
                form.TreeOfSelectedOperations.Nodes.RemoveAt(i);
            }

            StorageOfSelectedOperation.setIndexSelectedOperation(numberOfOperations);
            form.TreeOfSelectedOperations.SelectedNode = form.TreeOfSelectedOperations.Nodes[numberOfOperations];
        }

        public void deleteOperation(int indexOfOperation)
        {
           try
           {
                this.operations.RemoveAt(indexOfOperation);
           }
           catch { }
        }

        private string[] changeTypeOfInstrument(string[] typeOfInstrument)
        {
            try
            {
                for (int i = 2; i < typeOfInstrument.Length; i++)
                {
                    if (typeOfInstrument[i].Equals("не выбрано"))
                    {
                        typeOfInstrument[i] = typeOfInstrument[i - 1];
                    }
                }
            }
            catch { }

            return typeOfInstrument;
        }

        

    }
}
