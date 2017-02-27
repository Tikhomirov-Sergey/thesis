using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Surfaces
    {
        private static Operations[] surfaces = new Operations[1];
        
        public static void setOpetations(Operations operations)
        {
            int length = surfaces.Length;
            Array.Resize(ref surfaces, length + 1);
            surfaces[length] = operations;
        }

        public static Operations[] getSurfaces()
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

        public static Operations getSurfaceOnIndex(int indexSurface)
        {
            try
            { 
                return surfaces[indexSurface];
            }
            catch { return null; }
        }

        private static void checkSurface(int indexSurface)
        {
            if (SurfaceIsNull(surfaces[indexSurface]))
            {
                surfaces[indexSurface] = new Operations();
            }
        }

        private static bool SurfaceIsNull(Operations surface)
        {
            return (surface == null);
        }
 
    }
}
