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
                parametersOfSurfacesAfterVariousOperations = (ParametersOfSurfacesAfterVariousOperations)FileToObject.objectFromXML(@"XMLFiles/ParametersOfSurfacesAfterVariousOperations.xml", parametersOfSurfacesAfterVariousOperations);
            }
            return parametersOfSurfacesAfterVariousOperations;
        }

        public static ParametersOfWorkpieces getParametersOfWorkpieces()
        {
            if(parametersOfWorkpieces == null)
            {
                parametersOfWorkpieces = new ParametersOfWorkpieces();
                parametersOfWorkpieces = (ParametersOfWorkpieces)FileToObject.objectFromXML(@"XMLFiles/ParametersOfWorkpieces.xml", parametersOfWorkpieces);
            }
            return parametersOfWorkpieces;
        }

        public static InaccuracyOfPositioningPart getInaccuracyOfPositioningPart()
        {
            if (inaccuracyOfPositioningPart == null)
            {
                inaccuracyOfPositioningPart = new InaccuracyOfPositioningPart();
                inaccuracyOfPositioningPart = (InaccuracyOfPositioningPart)FileToObject.objectFromXML(@"XMLFiles/InaccuracyOfPositioningPart.xml", inaccuracyOfPositioningPart);
            }
            return inaccuracyOfPositioningPart;
        }

        public static TableOfTolerancesAndFits getTableOfTolerancesAndFits()
        {
            if (tableOfTolerancesAndFits == null)
            {
                tableOfTolerancesAndFits = new TableOfTolerancesAndFits();
                tableOfTolerancesAndFits = (TableOfTolerancesAndFits)FileToObject.objectFromXML(@"XMLFiles/TableOfTolerancesAndFits.xml", tableOfTolerancesAndFits);
            }
            return tableOfTolerancesAndFits;
        }

        public static CurvatureOfImpressionDieForgings getCurvatureOfImpressionDieForgings()
        {
            if (curvatureOfImpressionDieForgings == null)
            {
                curvatureOfImpressionDieForgings = new CurvatureOfImpressionDieForgings();
                curvatureOfImpressionDieForgings = (CurvatureOfImpressionDieForgings)FileToObject.objectFromXML(@"XMLFiles/CurvatureOfImpressionDieForgings.xml", curvatureOfImpressionDieForgings);
            }
            return curvatureOfImpressionDieForgings;
        }

        public static ShiftInAxisOfHoleDuringDrilling getShiftInAxisOfHoleDuringDrilling()
        {
           if (shiftInAxisOfHoleDuringDrilling == null)
            {
                shiftInAxisOfHoleDuringDrilling = new ShiftInAxisOfHoleDuringDrilling();
                shiftInAxisOfHoleDuringDrilling = (ShiftInAxisOfHoleDuringDrilling)FileToObject.objectFromXML(@"XMLFiles/ShiftInAxisOfHoleDuringDrilling.xml", shiftInAxisOfHoleDuringDrilling);
            }
            return shiftInAxisOfHoleDuringDrilling; 
        }
    }
}
