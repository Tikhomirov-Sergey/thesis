using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace WindowsFormsApplication8
{
    public partial class FormResult : System.Windows.Forms.Form
    {

        public FormResult()
        {
            InitializeComponent();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            ClickOnSurfacesTreeView.getSurfacesTreeView(this);

            ClickOnSurfacesTreeView.clickOnNode(1, this);
        }

        private void buttonSaveToDisk_Click(object sender, EventArgs e)
        {

            // string text = ClickOnSaveToFile.getText();
             SaveFileDialog sfd = new SaveFileDialog();
             sfd.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
           // int count = Convert.ToInt32(Part.getCountSurfaces);
            List<Surface> surfaces = Part.getSurfaces();

            int count = surfaces.Count;

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 StreamWriter sw = new StreamWriter(sfd.FileName);
                // sw.WriteLine(richTextBox1.Text);
           

            
                int typeOfPart = Part.getParametersOfPart().getTypeOfPart().getIndex();
                char type;

                if (typeOfPart == 0)
                {
                    type = '-';
                }
                else
                {
                    type = '+';
                }

                ClassesToCalculate.ResultsOfCalculation resultWorkpiece = Part.getWorkpiece().getResultsOfCalculation();


            sw.WriteLine("Исходные данные: " + Part.getWorkpiece().getNameOfWorkpiece() + "\nСоставляющая припуска P= " + resultWorkpiece.getSpatialDeviation().ToString() + "\nРазмер= " + resultWorkpiece.getSizeOfWorkprieceAfterOperation().ToString() + "(" + type + Part.getWorkpiece().getResultsOfCalculation().getAccuracies() + ")");

                for (int index = 0; index < count; index++)
                {
                    for (int i = 0; i < Part.getSurfaceOnIndex(index).getCountLongListOperation(); i++)
                    {
                        resultWorkpiece = Part.getSurfaceOnIndex(index).getParametersOperation()[i].getResultsOfCalculation();

                        sw.WriteLine("\n" + i.ToString() + ") ");
                        sw.WriteLine(Part.getSurfaceOnIndex(index).getParametersOperation()[i].getNameOperation());
                        sw.WriteLine("\nСоставляющая припуска E= " + resultWorkpiece.getdeviationOfInstallation().ToString() + "\nСоставляющая припуска P= " + resultWorkpiece.getSpatialDeviation().ToString() + "\nВеличина номинального припуска Znom= " + resultWorkpiece.getNominalAllowance().ToString() + "\nРазмер= " + resultWorkpiece.getSizeOfWorkprieceAfterOperation().ToString() + "(" + type + resultWorkpiece.getAccuracies() + ")");
                    }

                }

            sw.Close();
        }

    }

        private void buttonSaveToBase_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }

        private void SurfacesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ClickOnSurfacesTreeView.clickOnNode(e, this);
        }
    }
}
