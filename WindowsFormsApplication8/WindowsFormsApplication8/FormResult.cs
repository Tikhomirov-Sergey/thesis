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
            int typeOfPart = Part.getParametersOfPart().getTypeOfPart();
            char type;

            if (typeOfPart == 0)
                {
                    type = '-';
                }
            else
                {
                    type = '+';
                }

            ClassesToCalculate.ResultsOfCalculation resultsOfCalculation = Part.getSurfaceOnIndex(0).getResultsOfCalculation();

            richTextBoxResult.Text = "Исходные данные: " + Part.getWorkpiece().getNameOfWorkpiece() + "\nСоставляющая припуска P= " + resultsOfCalculation.getSpatialDeviation()[0].ToString() + "\nРазмер= " + resultsOfCalculation.getSizeOfWorkprieceAfterOperation()[0].ToString() + "(" + type + Part.getSurfaceOnIndex(0).getResultsOfCalculation().getAccuracies()[0] + ")";

            for (int i = 1; i <= Part.getSurfaceOnIndex(0).getNumberOfOperations(); i++)
            {
                richTextBoxResult.Text += "\n" + i.ToString() + ") ";
                richTextBoxResult.Text += Part.getSurfaceOnIndex(0).getListOperations()[i-1];
                richTextBoxResult.Text += "\nСоставляющая припуска E= " + resultsOfCalculation.getdeviationOfInstallation()[i].ToString() + "\nСоставляющая припуска P= " + resultsOfCalculation.getSpatialDeviation()[i].ToString() + "\nВеличина номинального припуска Znom= " + resultsOfCalculation.getNominalAllowance()[i].ToString() + "\nРазмер= " + resultsOfCalculation.getSizeOfWorkprieceAfterOperation()[i].ToString() + "(" + type + Part.getSurfaceOnIndex(0).getResultsOfCalculation().getAccuracies()[i]+ ")";
            }
        }

        private void buttonSaveToDisk_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(richTextBoxResult.Text);
                sw.Close();
            }
        }
    }
}
