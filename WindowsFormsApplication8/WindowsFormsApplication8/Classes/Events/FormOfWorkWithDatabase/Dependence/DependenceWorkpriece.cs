using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class DependenceWorkpriece
    {
        private int idInDb;
        private string nameWorkpriece;
        private int idWorkpriece;

        public DependenceWorkpriece(int idInDb, string nameWorkpriece, int idWorkpriece)
        {
            this.idInDb = idInDb;
            this.idWorkpriece = idWorkpriece;
            this.nameWorkpriece = nameWorkpriece;
        }


        public int getIdInDb()
        {
            return idInDb;
        }

        public int getIdWorkpriece()
        {
            return idWorkpriece;
        }

        public string getNameWorkpriece()
        {
            return nameWorkpriece;
        }
    }
}
