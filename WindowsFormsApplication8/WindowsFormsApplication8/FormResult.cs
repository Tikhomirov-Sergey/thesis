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

            ClassesToCalculate.ResultsOfCalculation f = Part.getSurfaceOnIndex(2).getResultsOfCalculation();
            richTextBoxResult.Text = "Исходные данные: " + Part.getWorkpiece().getNameOfWorkpiece() + "\nСоставляющая припуска P= " + f.getSpatialDeviation()[0].ToString() + "\nРазмер= " + f.getSizeOfWorkprieceAfterOperation()[0].ToString() + "(" + type + Part.getSurfaceOnIndex(2).getResultsOfCalculation().getAccuracies()[0] + ")";

            for (int i = 1; i <= Part.getSurfaceOnIndex(2).getCountLongListOperation(); i++)
            {
                richTextBoxResult.Text += "\n" + i.ToString() + ") ";
                richTextBoxResult.Text += Part.getSurfaceOnIndex(2).getParametersOperation()[i - 1].getNameOperation();
                richTextBoxResult.Text += "\nСоставляющая припуска E= " + f.getdeviationOfInstallation()[i].ToString() + "\nСоставляющая припуска P= " + f.getSpatialDeviation()[i].ToString() + "\nВеличина номинального припуска Znom= " + f.getNominalAllowance()[i].ToString() + "\nРазмер= " + f.getSizeOfWorkprieceAfterOperation()[i].ToString() + "(" + type + Part.getSurfaceOnIndex(2).getResultsOfCalculation().getAccuracies()[i]+ ")";
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

        private void buttonSaveToBase_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }
    }
}
