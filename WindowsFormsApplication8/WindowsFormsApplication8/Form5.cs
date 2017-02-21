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
using System.Data.SqlClient;

namespace WindowsFormsApplication8
{
    public partial class Form5 : Form
    {
        
       // Form4 z = new Form4("");
        int i;
        string dlina,diametr,tipRazmera,ObrabPov,tipPripuska,zagotovka,Pcm;
        string[] per = new string[1];
        string[] Rz = new string[1];
        string[] h = new string[1];
        string[] P = new string[1];
        string[] E = new string[1];
        string[] Ti = new string[1];
        string[] Znom = new string[1];
        string[] L = new string[1];
        string[] K = new string[1];
        string[] T = new string[1];
        string Dele;


        string[] Del2 = new string[1]; string[] Del3 = new string[1]; string[] Del4 = new string[1];

 string[] id = new string[1]; string[] CombInd = new string[1];


        public Form5(string data)
        {
            try
            {
                InitializeComponent();

                richTextBox1.Text = data;

                string[] Delenoe = richTextBox1.Text.Split('$');
                i = Convert.ToInt16(Delenoe[0]);
                dlina = (Delenoe[1]);
                diametr = (Delenoe[2]);
                tipRazmera = (Delenoe[6]);
                ObrabPov = (Delenoe[7]);
                tipPripuska = (Delenoe[8]);
                zagotovka = (Delenoe[9]);
                int schet = 10;


                /// Массив переходов    
                /// 
                /// 
                /// 
                /// 
                /// 
                ///  string[] Delenoe = richTextBox1.Text.Split('$');
                ///   i = Convert.ToInt16(Delenoe[0]);
                /// 1 - точение( черновое,цанговый патрон)
                Array.Resize(ref per, i);
                per[0] = Delenoe[9];

                for (int nom1 = 1; nom1 < i; nom1++)
                {

                    per[nom1] = Delenoe[schet];

                    schet = schet + 1;

                    // MessageBox.Show("переход номер:" + nom1 + "   значение:"+ per[nom1]+ "   Счетчик:" + schet,  "Hi");
                }
                Array.Resize(ref Del2, i);
                Array.Resize(ref Del3, i);
                Array.Resize(ref Del4, i);
                for (int nom1 = 1; nom1 < i; nom1++)
                {
                    Dele = per[nom1];
                    string[] Del1 = Dele.Split('-');

                    Del2[nom1] = Del1[1];

                    //    MessageBox.Show("р:"+ Del2[nom1],  "Hi");
                    // точение( черновое,цанговый патрон)
                }
                for (int nom1 = 1; nom1 < i; nom1++)
                { Del2[nom1] = Del2[nom1].Remove(0, 1); }
                //точение( черновое,цанговый патрон)
                for (int nom1 = 1; nom1 < i; nom1++)
                {
                    Dele = Del2[nom1];
                    string[] Del1 = Dele.Split('(');

                    Del3[nom1] = Del1[0];   /// переход
                    Del4[nom1] = Del1[1];/// черновое,цанговый патрон)


                    ///  MessageBox.Show("р:" + Del3[nom1], "Hi");
                }
                for (int nom1 = 1; nom1 < i; nom1++)
                {
                    Del4[nom1] = Del4[nom1].Remove(0, 1);
                    int Dl = (Del4[nom1].Length - 1);
                    Del4[nom1] = Del4[nom1].Remove(Dl, 1);

                    //   MessageBox.Show("р:" + Del4[nom1], "Hi"); //черновое,цанговый патрон
                }

                for (int nom1 = 1; nom1 < i; nom1++)
                {
                    Dele = Del4[nom1];
                    string[] Del1 = Dele.Split(',');

                    Del2[nom1] = Del1[0];   /// черновое
                    Del4[nom1] = Del1[1];///цанговый патрон


                    ///  MessageBox.Show("р:" + Del3[nom1], "Hi");
                }

                for (int nom1 = 1; nom1 < i; nom1++)
                {
                    Del3[nom1] = Del3[nom1] + ", " + Del2[nom1];
                    // MessageBox.Show("р:" + Del3[nom1], "1");
                    // MessageBox.Show("р:" + Del4[nom1], "1");
                }


                Array.Resize(ref Rz, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {

                    Rz[nom1] = Delenoe[schet];
                    schet = schet + 1;

                    // MessageBox.Show("переход номер:" + nom1 + "   значение:" + Rz[nom1] + "   Счетчик:" + schet, "Hi");
                }

                Array.Resize(ref h, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    h[nom1] = Delenoe[schet];

                    schet = schet + 1;
                    //MessageBox.Show("переход номер:" + nom1 + "   значение:" + h[nom1] + "   Счетчик:" + schet, "Hi");
                }
                Array.Resize(ref P, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    P[nom1] = Delenoe[schet];

                    schet = schet + 1;
                }
                Array.Resize(ref E, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    E[nom1] = Delenoe[schet];
                    schet = schet + 1;
                }

                Array.Resize(ref Ti, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    Ti[nom1] = Delenoe[schet];
                    schet = schet + 1;
                }

                Array.Resize(ref Znom, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    Znom[nom1] = Delenoe[schet];
                    schet = schet + 1;
                }

                Array.Resize(ref L, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    L[nom1] = Delenoe[schet];
                    schet = schet + 1;
                }

                Pcm = Delenoe[schet];
                K[0] = Delenoe[schet];
                schet = schet + 1;

                Array.Resize(ref K, i);
                for (int nom1 = 1; nom1 < i; nom1++)
                {
                    K[nom1] = Delenoe[schet];
                    schet = schet + 1;
                }
                Array.Resize(ref T, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    T[nom1] = Delenoe[schet];
                    schet = schet + 1;
                    // MessageBox.Show("переход номер:" + nom1 + "   значение:" + T[nom1] + "   Счетчик:" + schet, "Hi");
                }

                //// ID
                Array.Resize(ref id, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    id[nom1] = Delenoe[schet];
                    schet = schet + 1;
                }
                ////   id приспособьления
                Array.Resize(ref CombInd, i);
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    CombInd[nom1] = Delenoe[schet];
                    schet = schet + 1;
                }

                double glubina = Convert.ToDouble(Delenoe[schet]);

                this.data = data;
            }
            catch { }

        }
        string data;
     


        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "juliaDataSet.Переходы". При необходимости она может быть перемещена или удалена.
            this.переходыTableAdapter.Fill(this.juliaDataSet.Переходы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "juliaDataSet.Деталь". При необходимости она может быть перемещена или удалена.
            this.детальTableAdapter1.Fill(this.juliaDataSet.Деталь);

            
         //  z.dataGridView1.Rows.Add(per);


            ///   i - количество переходов
            ///   
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "juliaDataSet.Переходы". При необходимости она может быть перемещена или удалена.
           

            //dataGridView2.Rows.Count.ToString());
            //int i = Convert.ToInt32(dataGridView2.Rows.Count.ToString());
            int nom = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
          //  for (int nom1 = 0; nom1 < 2; nom1++)
        //    {
          //  MessageBox.Show(Convert.ToString(i),"i");

         //this.dataGridView1.Rows[4].Cells[0].Value = "nomer detali";


            /*      this.dataGridView1.Rows[nom - 1].Cells[0].Value = "nomer detali";
                this.dataGridView1.Rows[nom - 1].Cells[1].Value = "naimen";
                this.dataGridView1.Rows[nom - 1].Cells[2].Value = "data";
               this.dataGridView1.Rows[nom - 1].Cells[3].Value = dlina;
                this.dataGridView1.Rows[nom - 1].Cells[4].Value = diametr;
                this.dataGridView1.Rows[nom - 1].Cells[5].Value = " ";
                this.dataGridView1.Rows[nom- 1].Cells[6].Value = "n2";
                this.dataGridView1.Rows[nom - 1].Cells[7].Value = "n3";
                this.dataGridView1.Rows[nom - 1].Cells[8].Value = tipRazmera;
                this.dataGridView1.Rows[nom - 1].Cells[9].Value = ObrabPov;
                this.dataGridView1.Rows[nom - 1].Cells[10].Value = tipPripuska;
                this.dataGridView1.Rows[nom - 1].Cells[11].Value = zagotovka;
            

             

           for (int nom1=0; nom1<i; nom1++)
             {

                 this.dataGridView2.Rows[nom].Cells[0].Value = "nomer detali";
                 this.dataGridView2.Rows[nom].Cells[1].Value = nom1;
                 this.dataGridView2.Rows[nom].Cells[2].Value = Del3[nom1+1];
                 this.dataGridView2.Rows[nom].Cells[3].Value = Del4[nom1+1];

                 this.dataGridView2.Rows[nom].Cells[4].Value = Rz[nom1];
                 this.dataGridView2.Rows[nom].Cells[5].Value = h[nom1];
                 this.dataGridView2.Rows[nom].Cells[6].Value = P[nom1];
                 this.dataGridView2.Rows[nom].Cells[7].Value = E[nom1];
                 this.dataGridView2.Rows[nom].Cells[8].Value = Ti[nom1];
                 this.dataGridView2.Rows[nom].Cells[9].Value = Znom[nom1];
                 this.dataGridView2.Rows[nom].Cells[10].Value = L[nom1];
                 this.dataGridView2.Rows[nom].Cells[11].Value = K[nom1];
                 this.dataGridView2.Rows[nom].Cells[12].Value = T[nom1];
             }*/
          //  this.dataGridView1.Rows.Add();
              //this.dataGridView1.Rows[5].Cells[1].Value = "ksiksi";
              


        //    this.детальTableAdapter.Update(this.juliaDataSet.Деталь);
        //    this.переходыTableAdapter.Update(this.juliaDataSet.Переходы);


          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // try
           /// {
               string[] sp = zagotovka.Split(new Char[] { '-' });
                zagotovka = sp[1];
                Del3[0] = zagotovka;
            
                детальTableAdapter1.Insert(textBox1.Text, DateTime.Now, (float)Convert.ToDouble(dlina), (float)Convert.ToDouble(diametr), (float)Convert.ToDouble(Ti[i - 1]), (float)Convert.ToDouble(Rz[i - 1]), (float)Convert.ToDouble(h[i - 1]), tipRazmera, ObrabPov, tipPripuska, zagotovka, textBox2.Text);
                //детальTableAdapter1.Insert(textBox1.Text, DateTime.Now, (float)Convert.ToDouble(dlina), (float)Convert.ToDouble(diametr), (float)Convert.ToDouble(Ti[i - 1]), (float)Convert.ToDouble(Rz[i - 1]), (float)Convert.ToDouble(h[i - 1]), tipRazmera, ObrabPov, tipPripuska, zagotovka,textBox2.Text);
                int index = this.dataGridView1.NewRowIndex;
                for (int nom1 = 0; nom1 < i; nom1++)
                {
                    переходыTableAdapter.Insert(Convert.ToInt16(this.dataGridView1[0, index - 1].Value.ToString()) + 1, nom1, Del3[nom1], Del4[nom1], (float)Convert.ToDouble(Rz[nom1]), (float)Convert.ToDouble(h[nom1]), (float)Convert.ToDouble(P[nom1]), (float)Convert.ToDouble(E[nom1]), (float)Convert.ToDouble(Ti[nom1]), (float)Convert.ToDouble(Znom[nom1]), (float)Convert.ToDouble(L[nom1]), Convert.ToInt16(id[nom1]), Convert.ToInt16(CombInd[nom1]), (float)Convert.ToDouble(K[nom1]), Convert.ToInt16(T[nom1]));
                }
                MessageBox.Show("Сохранение прошло удачно");
           // }
           // catch { MessageBox.Show("Ошибка, попробуйте ещё раз"); }
          Close();
            /*  i = Convert.ToInt16(Delenoe[0]);
            dlina = (Delenoe[1]);
            diametr = (Delenoe[2]);
            tipRazmera = (Delenoe[6]);
            ObrabPov = (Delenoe[7]);
            tipPripuska = (Delenoe[8]);
            zagotovka = (Delenoe[9]);
            string[] per = new string[1];
            string[] Rz = new string[1];
            string[] h = new string[1];
            string[] P = new string[1];
            string[] E = new string[1];
            string[] Ti = new string[1];
            string[] Znom = new string[1];
            string[] L = new string[1];
            string[] K = new string[1];
            string[] T = new string[1];
            string Dele;*/
               
             
               
           

       }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.juliaDataSet);
        }*/

        
     }
}
