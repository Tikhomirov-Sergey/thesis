﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Part
    {
        private static ParametersOfPart parametersOfPart = null;
        private static ParametersWorkpiece workpriece = null;
        private static Surface[] surfaces = new Surface[1];
        
        public static ParametersOfPart getParametersOfPart()
        {
            return parametersOfPart;
        }

        public static void setParametersOfPart(ParametersOfPart parametersOfPart)
        {
            Part.parametersOfPart = parametersOfPart;
        }

        public static ParametersWorkpiece getWorkpiece()
        {
            return workpriece;
        }

        public static void setWorkpiece(ParametersWorkpiece workpirece)
        {
            Part.workpriece = workpirece;
        }

        public static void setOpetations(Surface operations)
        {
            int length = surfaces.Length;
            Array.Resize(ref surfaces, length + 1);
            surfaces[length] = operations;
        }

        public static Surface[] getSurfaces()
        {
            return surfaces;
        }

        public static void addOperationInSurface(ParametersOperation operation, int indexSurface)
        {
            try
            {
                checkSurface(indexSurface);
                surfaces[indexSurface].setOpetation(operation);
            }
            catch { }
        }

        public static Surface getSurfaceOnIndex(int indexSurface)
        {
            try
            { 
                return surfaces[indexSurface];
            }
            catch { return null; }
        }

        public static void calculationOfSurfaces()
        {
            foreach (Surface surface in Part.surfaces)
            {
                surface.calculationOFSurface();
            }
        }

        private static void checkSurface(int indexSurface)
        {
            if (SurfaceIsNull(surfaces[indexSurface]))
            {
                surfaces[indexSurface] = new Surface();
            }
        }

        private static bool SurfaceIsNull(Surface surface)
        {
            return (surface == null);
        }
    }
}
