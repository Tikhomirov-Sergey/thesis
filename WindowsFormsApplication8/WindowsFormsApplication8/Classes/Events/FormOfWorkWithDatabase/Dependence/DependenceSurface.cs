using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class DependenceSurface
    {
        private int idInDb;
        private string nameSurface;
        private ParametersOfSurface parametersOfSurface;

        public DependenceSurface(int idInDb, string nameSurface, double diameter, TypeOfPart typeOfPart, TypeOfPart typeOfAllowance, 
            TypeOfPart typeOfProcessedSurface, double surfaceRoughness, double tolerance, double holeDepth)
        {
            this.idInDb = idInDb;
            this.nameSurface = nameSurface;
            this.parametersOfSurface = new ParametersOfSurface(diameter, typeOfPart, typeOfAllowance, typeOfProcessedSurface, surfaceRoughness, tolerance, holeDepth);
        }

        public int getIdInDb()
        {
            return idInDb;
        }

        public ParametersOfSurface getParametersOfSurface()
        {
            return parametersOfSurface;
        }

        public string getNameSurface()
        {
            return nameSurface;
        }
    
    }
}
