using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Tables
    {
        private static ParametersOfSurfacesAfterVariousOperations parametersOfSurfacesAfterVariousOperations = null;
        private static ParametersOfWorkpieces parametersOfWorkpieces = null;
        private static InaccuracyOfPositioningPart inaccuracyOfPositioningPart = null;
        private static TableOfTolerancesAndFits tableOfTolerancesAndFits = null;
        private static CurvatureOfImpressionDieForgings curvatureOfImpressionDieForgings = null;
        private static ShiftInAxisOfHoleDuringDrilling shiftInAxisOfHoleDuringDrilling = null;
        
        public static ParametersOfSurfacesAfterVariousOperations getParametersOfSurfacesAfterVariousOperations()
        {
            if (parametersOfSurfacesAfterVariousOperations == null)
            {
                parametersOfSurfacesAfterVariousOperations = new ParametersOfSurfacesAfterVariousOperations();
                parametersOfSurfacesAfterVariousOperations = (ParametersOfSurfacesAfterVariousOperations)JsonToObject.objectFromJson(@"XMLFiles/ParametersOfSurfacesAfterVariousOperations.json", parametersOfSurfacesAfterVariousOperations);
            }
            return parametersOfSurfacesAfterVariousOperations;
        }

        public static ParametersOfWorkpieces getParametersOfWorkpieces()
        {
            if(parametersOfWorkpieces == null)
            {
                parametersOfWorkpieces = new ParametersOfWorkpieces();
                parametersOfWorkpieces = (ParametersOfWorkpieces)JsonToObject.objectFromJson(@"XMLFiles/ParametersOfWorkpieces.json", parametersOfWorkpieces);
            }
            return parametersOfWorkpieces;
        }

        public static InaccuracyOfPositioningPart getInaccuracyOfPositioningPart()
        {
            if (inaccuracyOfPositioningPart == null)
            {
                inaccuracyOfPositioningPart = new InaccuracyOfPositioningPart();
                inaccuracyOfPositioningPart = (InaccuracyOfPositioningPart)JsonToObject.objectFromJson(@"XMLFiles/InaccuracyOfPositioningPart.json", inaccuracyOfPositioningPart);
            }
            return inaccuracyOfPositioningPart;
        }

        public static TableOfTolerancesAndFits getTableOfTolerancesAndFits()
        {
            if (tableOfTolerancesAndFits == null)
            {
                tableOfTolerancesAndFits = new TableOfTolerancesAndFits();
                tableOfTolerancesAndFits = (TableOfTolerancesAndFits)JsonToObject.objectFromJson(@"XMLFiles/TableOfTolerancesAndFits.json", tableOfTolerancesAndFits);
            }
            return tableOfTolerancesAndFits;
        }

        public static CurvatureOfImpressionDieForgings getCurvatureOfImpressionDieForgings()
        {
            if (curvatureOfImpressionDieForgings == null)
            {
                curvatureOfImpressionDieForgings = new CurvatureOfImpressionDieForgings();
                curvatureOfImpressionDieForgings = (CurvatureOfImpressionDieForgings)JsonToObject.objectFromJson(@"XMLFiles/CurvatureOfImpressionDieForgings.json", curvatureOfImpressionDieForgings);
            }
            return curvatureOfImpressionDieForgings;
        }

        public static ShiftInAxisOfHoleDuringDrilling getShiftInAxisOfHoleDuringDrilling()
        {
           if (shiftInAxisOfHoleDuringDrilling == null)
            {
                shiftInAxisOfHoleDuringDrilling = new ShiftInAxisOfHoleDuringDrilling();
                shiftInAxisOfHoleDuringDrilling = (ShiftInAxisOfHoleDuringDrilling)JsonToObject.objectFromJson(@"XMLFiles/ShiftInAxisOfHoleDuringDrilling.json", shiftInAxisOfHoleDuringDrilling);
            }
            return shiftInAxisOfHoleDuringDrilling; 
        }
    }
}
