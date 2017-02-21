using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Xml;
using System.IO;

namespace WindowsFormsApplication8
{
    public partial class Form3 : Form
    {
        Form1 lo;
        Bitmap bitmap;
        new int i;
        new int dlina;   /// переменная для расчета масштаба
        new double M;
        new string tip; /// вал или отверствие
        string DlyaSoxr;


        int[] Tdd = new int[1];
        string[] TddS = new string[1];
        string[] Zmind = new string[1];
        int[] Td = new int[1];
        string[] TdS = new string[1];

        public Form3(string data)
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            richTextBox2.Text = data;

            this.data = data;



            string a = richTextBox2.Text;


            string[] Delim = a.Split('#');

            DlyaSoxr = Delim[1];

            string[] b = Delim[0].Split('|');
            richTextBox1.Text = (b[0]);

       //     string[] DlyaSoxr = a.Split('#');

            textBox1.Text = Convert.ToString(b[1]);   //// b[1] - i

            label1.Text = Convert.ToString(b[2]);
            label2.Text = Convert.ToString(b[3]);
            tip = b[3];

            textBoxTd0.Text = b[4];    /// d начальное

            i = Convert.ToInt16(textBox1.Text);
            int Nom = 5;
            Array.Resize(ref Tdd, i);
            Array.Resize(ref Td, i);
            Array.Resize(ref TdS, i);
            Array.Resize(ref TddS, i);


            Td[0] = Convert.ToInt32(Math.Round(Convert.ToDouble(b[4])));
            //// d - label3   td - label5


            for (int nom1 = i - 1; nom1 > 0; nom1--)
            {
                label3.Text = label3.Text + "\n" + "d" + Convert.ToString(nom1) + "=" + b[Nom];
               

                Td[nom1] = Convert.ToInt32(Math.Round(Convert.ToDouble(b[Nom])));
                TdS[nom1] = b[Nom];

                Nom++;

            }
            label3.Text = label3.Text + "\n" + "d0=" + b[4];
            TdS[0] = b[4];

            for (int nom1 = i - 1; nom1 >= 0; nom1--)
            {
                label5.Text = label5.Text + "\n" + "Td" + Convert.ToString(nom1) + "=" + b[Nom];
               

                Tdd[nom1] = Convert.ToInt32(Math.Round(Convert.ToDouble(b[Nom])));
                TddS[nom1] = b[Nom];

                Nom++;

            }
            if (b[3] == "0")
            {
                for (int nom1 = i - 1; nom1 >= 0; nom1--)
                {
                    label6.Text = label6.Text + "\n" + "d" + Convert.ToString(nom1) + "=" + TdS[nom1] + "(-" + TddS[nom1] + ")";
                }
            }
            else
            {
                for (int nom1 = i - 1; nom1 >= 0; nom1--)
                {
                    label6.Text = label6.Text + "\n" + "d" + Convert.ToString(nom1) + "=" + TdS[nom1] + "(+" + TddS[nom1] + ")";
                }
            }

            /// Добавление Td
            //          for (int ky = 0; ky < i; ky++)
            //    {
            //        label5.Text = label5.Text + "\n" + b[Nom];

            //        Td[ky] = b[Nom];

            //        Nom++;
            //     }


        }

        string data;

        private void button1_Click(object sender, EventArgs e)
        {

            /*        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
            streamWriter.WriteLine(label2.Text);
            streamWriter.Close();
        }
        */
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(label1.Text);
                sw.Close();
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            
         //   textBox3.Text = p.textBox2.Text;
            textBox3.Text = textBox2.Text;


            /*    Graphics g = CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            Form3_Paint(sender, es); */



            Graphics gr = Graphics.FromImage(bitmap);

            double xa = Convert.ToDouble(textBoxTd0.Text);
            double x = Math.Round(xa);
            int x2 = Convert.ToInt16(x);

            Pen pen = new Pen(Color.Black, 1.0F);


            // x y дл выс      isx - Исходный х (770)     isy - исходный y (50)         x2- Td0
            // 1                        
            //       gr.DrawRectangle(Pens.Black, 770, 50, x2, 260);

            Pen penL = new Pen(Color.Black, 1.0F);
            penL.CustomEndCap = new AdjustableArrowCap(2.0F, 2.0F);


            int isx = 50;
            int isy = 60;

            ///  Цикл выбора масштаба по ширине листа
            for (int Shag = 1; Shag <= i; Shag++)
            {
                int Shir = pictureBox1.Width; ///Ширина PictureBox


            };

            bool Stat = true; dlina = 0; Tdd[0] = 0; M = 1;


            for (int nom1 = i - 1; nom1 >= 0; nom1--)
            {
                Tdd[nom1] = Tdd[nom1] + 30;
                Td[nom1] = Td[nom1] + 40;

            }


            //// Выбор масштаба
            /* while(Stat)
            {
            for (int nom1 = i - 1; nom1 >= 0; nom1--)
            {
                dlina = dlina + Convert.ToInt32(Td[nom1]) + 100 + Convert.ToInt32(Tdd[nom1]);
                MessageBox.Show(Convert.ToString(dlina), "dlina pictureBox1");
            }
            if (dlina > 1000) M = M * 0.95; else Stat = false;
            dlina = 0;
            }
            */

           
                int T = 20 * (i + 2);
                int d = 20;
                int dl = 52;

                for (int nom1 = i - 1; nom1 > 0; nom1--)
                {

                    if (nom1 == i - 1) gr.DrawLine(pen, isx + 40 - 40, isy, isx + 40 - 40, isy + 82 + T);
                    dl = dl + 40;
                    gr.DrawLine(pen, isx + 40, isy, isx + 40 - 40, isy);     //верх
                    gr.DrawLine(pen, isx + 40, isy + 80, isx + 40 - 40, isy + 80);     //низ

                    gr.DrawLine(pen, isx + 40, isy, isx + 40, isy + 100);         /// право
                    gr.DrawLine(pen, isx + 40 - 40, isy, isx + 40 - 40, isy + 100);   ///лево


                    gr.DrawLine(penL, isx + 40, isy + 98, isx + 40 - 40, isy + 98);  // стрелки для Tdd
                    gr.DrawLine(penL, isx + 40 - 40, isy + 98, isx + 40, isy + 98);  //


                    gr.DrawLine(pen, isx + 40, isy, isx + 40, isy + 122 + d);     // стрелки для Td
                    gr.DrawLine(penL, 50 + 40 - 40, isy + 120 + d, isx + 40, isy + 120 + d);  //


                    Label TddL = new Label() { Parent = pictureBox1 };   /// label Tdd
                    TddL.Name = "Td" + (nom1);
                    TddL.Text = "Td" + (nom1);
                    TddL.Visible = true;
                    TddL.Font = new Font("Arial Bold", 7);
                    TddL.Size = new System.Drawing.Size(26, 12);
                    TddL.Location = new System.Drawing.Point(isx - 9 + (40) - (40 / 2), isy + 83);

                    Label TdL = new Label() { Parent = pictureBox1 };   /// label Td
                    TdL.Name = "d" + (nom1);
                    TdL.Text = "d" + (nom1);
                    TdL.Visible = true;
                    TdL.Font = new Font("Arial Bold", 7);
                    TdL.Size = new System.Drawing.Size(26, 12);
                    TdL.Location = new System.Drawing.Point(dl / 2 + 40 / 2 - 4, isy + 106 + d);


                    d = d + 20;
                    isx = isx + 40 + 20;


                }
                /// нулевой
                gr.DrawLine(pen, isx + 40, isy, isx + 40 - 40, isy);     //верх
                gr.DrawLine(pen, isx + 40, isy + 80, isx + 40 - 40, isy + 80);     //низ

                gr.DrawLine(pen, isx + 40, isy, isx + 40, isy + 100);         /// право
                gr.DrawLine(pen, isx + 40 - 40, isy, isx + 40 - 40, isy + 100);   ///лево

                gr.DrawLine(penL, isx + 40, isy + 98, isx + 40 - 40, isy + 98);  // стрелки для Tdd
                gr.DrawLine(penL, isx + 40 - 40, isy + 98, isx + 40, isy + 98);  //

                Label TddL0 = new Label() { Parent = pictureBox1 };   /// label Tdd
                TddL0.Name = "Td" + (0);
                TddL0.Text = "Td" + (0);
                TddL0.Visible = true;
                TddL0.Font = new Font("Arial Bold", 6);
                TddL0.Size = new System.Drawing.Size(20, 10);
                TddL0.Location = new System.Drawing.Point(isx - 7 + (40) - (40 / 2), isy + 87);

                gr.DrawLine(pen, isx + 40, isy, isx + 40, isy + 122 + d);     // стрелки для Td
                gr.DrawLine(penL, 50 + 40 - 40, isy + 120 + d, isx + 40, isy + 120 + d);  //

                dl = dl + 40;
                Label TdL0 = new Label() { Parent = pictureBox1 };   /// label Td
                TdL0.Name = "d" + (0);
                TdL0.Text = "d" + (0);
                TdL0.Visible = true;
                TdL0.Font = new Font("Arial Bold", 6);
                TdL0.Size = new System.Drawing.Size(20, 10);
                TdL0.Location = new System.Drawing.Point(dl / 2 + 40 / 2, isy + 110 + d);

          


            /// Для исходного




            /*       for (int Shag = 1; Shag < i; Shag++)
                    {
                        int[] dTd = new int[i];
                        int[] dZmin = new int[i];

                
            /// для 1 шага перемещаем точку ISX- zmin - td   
                        /// b[5] до( b[5] + i-1 )это TD ; 
                        /// (b[5] + i-1) до [ (b[5] + i-1) + i-1 ] это Z min

                        //   isx = isx - b[5 + Shag] - b[5 + Shag + (i - 1)];
                        //  double isxD = isx - 
                        // isx = isx - Zmind[Shag-1]

                        double Zmin = Convert.ToDouble(Zmind[Shag - 1]);   /// Конвертируем из массива в вещественное
                        double ZminOk = Math.Round(Zmin);                  /// Округляем
                        int Zm = Convert.ToInt16(ZminOk);                  /// Integer
                        dZmin[Shag - 1] = Zm;                              /// В массив

                        double Tdmin = Convert.ToDouble(Td[Shag - 1]);
                        double TdminOk = Math.Round(Tdmin);
                        int TD = Convert.ToInt16(TdminOk);


                        double Tddmin = Convert.ToDouble(Tdd[Shag - 1]);
                        double TddminOk = Math.Round(Tddmin,0);
                        int TDD = Convert.ToInt32(TddminOk);
                        dTd[Shag - 1] = TDD; 


                        Zm = Zm + 20;

                     //   MessageBox.Show(Tdd[Shag - 1], Convert.ToString(TDD));
                        /// На 1 шаге рисуем  по исходной точке isx и isy    высота вниз на 70
                        /// Tdd программы - d рисунка
                        /// 

          


                        gr.DrawLine(pen, isx, isy, isx + TDD, isy);     //верх
                        gr.DrawLine(pen, isx, isy + 60, isx + TDD, isy + 60); // низ

                        gr.DrawLine(pen, isx + TDD, isy, isx + TDD, isy + 60);         /// право
                        gr.DrawLine(pen, isx, isy, isx, isy + 60);   ///лево
                                                                     ///
                        gr.DrawLine(pen, isx, isy+60, isx, isy + 80);  // левая палка
                        gr.DrawLine(pen, isx + TDD, isy + 60, isx + TDD, isy + 80); //правая палка

                        gr.DrawLine(penL, isx, isy + 60 + 18, isx + TDD, isy + 60 + 18);  // стрелки для Td
                        gr.DrawLine(penL, isx + TDD, isy + 60 + 18, isx, isy + 60 + 18);  //

              Label lTd = new Label() { Parent = pictureBox1 };   /// label Td
              lTd.Name = "Td" + (i - Shag);
                        lTd.Text = "Td" + (i - Shag);
                        lTd.Visible = true;
                        lTd.Font = new Font("Arial Bold", 6);
                        lTd.Size = new System.Drawing.Size(30, 10);
                        lTd.Location = new System.Drawing.Point((isx + (TDD/2) - 10), (isy+60+7));

                        if (Shag > 1)
                        {
                            if (Shag % 2 == 0)
                            {
                                gr.DrawLine(penL, isx + TDD, isy - 40, isx - TDD - Zm, isy - 40);  // стрелки для Zmax
                                gr.DrawLine(penL, isx - TDD - Zm, isy - 40, isx + TDD, isy - 40);  //
                                gr.DrawLine(pen, isx + TDD, isy - 40, isx + TDD, isy); //правая палка
                                gr.DrawLine(pen, isx - TDD - Zm, isy - 40, isx - TDD - Zm, isy); //левая палка

                                Label lZmax = new Label() { Parent = pictureBox1 };   /// label lZmax
                                lZmax.Name = "Z" + (i - Shag+1) + "max";
                                lZmax.Text = "Z" + (i - Shag+1) + "max";
                                lZmax.Visible = true;
                                lZmax.Font = new Font("Arial Bold", 6);
                                lZmax.Size = new System.Drawing.Size(30, 10);
                                lZmax.Location = new System.Drawing.Point(((isx - dTd[Shag - 2] - dZmin[Shag - 2]) + ((dTd[Shag - 2] + TDD + dZmin[Shag - 2]) / 2) -10), (isy - 50));
                              //  lZmax.Location = new System.Drawing.Point((isx + TDD - ((dTd[Shag - 2] + TDD + dZmin[Shag - 2]) / 2) - 10), (isy - 50));
                            }
                            else
                            {
                                gr.DrawLine(penL, isx + TDD, isy - 20, isx - TDD - Zm, isy - 20);  // стрелки для Zmax
                                gr.DrawLine(penL, isx - TDD - Zm, isy - 20, isx + TDD, isy - 20);  //
                                gr.DrawLine(pen, isx + TDD, isy - 20, isx + TDD, isy); //правая палка
                                gr.DrawLine(pen, isx - TDD - Zm, isy - 20, isx - TDD - Zm, isy); //левая палка

                                Label lZmax = new Label() { Parent = pictureBox1 };   /// label lZmax
                                lZmax.Name = "Z" + (i - Shag + 1) + "max";
                                lZmax.Text = "Z" + (i - Shag + 1) + "max";
                                lZmax.Visible = true;
                                lZmax.Font = new Font("Arial Bold", 6);
                                lZmax.Size = new System.Drawing.Size(30, 10);
                                lZmax.Location = new System.Drawing.Point(((isx - dTd[Shag - 2] - dZmin[Shag - 2]) + ((dTd[Shag - 2] + TDD + dZmin[Shag - 2]) / 2) - 10), (isy - 30));
                            }
                        }

                       // MessageBox.Show("", lTd.Text);
               
                      //  { double Td0 = Convert.ToDouble(textBoxTd0.Text); Td0 = Math.Round(Td0); isx = (isx + Convert.ToInt32(Td0) + Zm); MessageBox.Show("", Convert.ToString(isx)); }
                
                            isx = isx + TDD + Zm;



                        string isxS = Convert.ToString(isx);

                

                    } */
         //   Form1 p = new Form1();  
                pictureBox1.Image = bitmap;
          // richTextBox4.Text = p.richTextBox1.Text;
        }

        private void Form3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 Y = new Form5(this.DlyaSoxr);
            Y.ShowDialog(); Close();
        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            Form5 Z = new Form5(l.richTextBox3.Text);
            Z.ShowDialog();
        }*/


    }
}
