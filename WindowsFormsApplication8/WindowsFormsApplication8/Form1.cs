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


namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDoc;
        string xmlpath = @"table2.xml"; Form2 f = new Form2(); Form4 z = new Form4("");//Form5 z = new Form5();

        int tip_det, tip_obr_pov, tip_prip, vid_zag, tip; int i = 1; int level; string[] split_data; string[] split_data1,split_data2; string[] per = new string[1];
        double[] Rz = new double[1]; double[] h = new double[1]; double[] T = new double[1]; double[] K = new double[1];int[] E1 = new int[1]; 
        double[] P = new double[1]; double[] E = new double[1]; char[] id = new char[1]; int[] id_per = new int[1]; string sid; string sid_per; string[] hh = new string[1]; int[] mas1 = new int[1]; bool[] Epr = new bool[1];
        bool per_0 = false; string[] prib = new string[1]; public double[] Zmin = new double[1]; double[] Znom = new double[1]; double[] Zag = new double[1]; double[] L = new double[1]; int[] CombInd = new int[1]; double[] Ti = new double[1]; string l = ""; string l2 = ""; string l3; double Pcm = 0; string stroka;
        double Ra_max, Ra_min;
        double Rz_max, Rz_min;
        public string Zmi2n;
       
        string[] Tdd = new string[1];
        string[] Zmind = new string[1];
        string[] Td = new string[1];
       // Массив округлений 
        double[] ZminDouble = new double[1];


        string[,] t1 = new string[,] { { "не выбрано", "12345678", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
            {"патрон трёхкулачковый","13","0,220","0,270","0,320","0,370","0,420","0,5","0,6","0,7","0,8","0,9"},
                               {" ","467","0,050","0,060","0,070","0,080","0,100","0,120","0,14","0,16","0,18","0,2"},
                               {" ","58","0,025","0,030","0,0350","0,040","0,050","0,06","0,07","0,08","0,09","0,1"},
                               {" ","2","0,22","0,270","0,320","0,370","0,420","0,5","0,6","0,7","0,8","0,9"},
                               {"цанговый патрон","674","0,040","0,050","0,060","0,070","0,080","0","0","0","0","0"},
                               {" ","18523","0,020","0,025","0,03","0,0350","0,04","0","0","0","0","0"},
                               {"гладкие центры","12834567","0,02","0,020","0,020","0,040","0,040","0,04","0","0","0","0"},
        {"с винтовыми или эксцентриковыми зажимами","12367","0,09","0,10","0,110","0,120","0,135","0,15","0,175","0,2","0,24","0,28"},
                               {" ","48","0,040","0,050","0,060","0,070","0,08","0,090","0,1","0,11","0,12","0,13"},
                               {" ","5","0,03","0,040","0,050","0,060","0,070","0,08","0,09","0,1","0,11","0,12"},
                               {"с пневматическим зажимом","32167","0,07","0,08","0,09","0,1","0,110","0,12","0,14","0,16","0,19","0,22"},
                               {" ","48","0,030","0,040","0,050","0,060","0,070","0,08","0,09","0,1","0,11","0,12"},
                               {" ","  5","0,010","0,020","0,030","0,040","0,050","0,06","0,07","0,08","0,09","0,1"},
                               {"1111"," 0","0","0","0","0","0","0","0","0","0","0"}

                             };
       
        string[,] t2 = new string[,]{{"С винтовыми или эксцентриковыми зажимами","123","0,09","0,10","0,110","0,120","0,135","0,15","0,175","0,2","0,24","0,28"},
                               {" ","4","0,040","0,050","0,060","0,070","0,08","0,090","0,1","0,11","0,12","0,13"},
                               {" ","5","0,03","0,040","0,050","0,060","0,070","0,08","0,09","0,1","0,11","0,12"},
                               {"С пневматическим зажимом","321","0,07","0,08","0,09","0,1","0,110","0,12","0,14","0,16","0,19","0,22"},
                               {" ","48","0,030","0,040","0,050","0,060","0,070","0,08","0,09","0,1","0,11","0,12"},
                               {" ","5","0,010","0,020","0,030","0,040","0,050","0,06","0,07","0,08","0,09","0,1"}};
        int[,] t1_diam = new int[,] { { 6, 10, 18, 30, 50, 80, 120, 180, 260, 360 }, { 10, 18, 30, 50, 80, 120, 180, 260, 360, 500 } };



        double[,] t3 = new double[,]{{0,25,50,80,120,180},
                               {25,50,80,120,180,3150},
                               {0.004,0.003,0.002,0.0018,0.0016,0.0014 }
                             };
        double[,] t4 = new double[,]{{0,6.1,10.1,18.1,30.1},
                               {6,10,18,30,3150},
                               {0.0021,0.0017,0.0013,0.0009,0.0007}
                             };





        int[,] table3_1 = new int[,] { { 0, 3 }, { 3, 6 }, { 6, 10 }, { 10, 18 }, { 18, 30 }, { 30, 50 }, { 50, 80 }, { 80, 120 }, { 120, 180 }, { 180, 250 }, { 250, 315 }, { 315, 400 }, { 400, 500 }, { 500, 630 }, { 630, 800 }, { 800, 1000 }, { 1000, 1250 }, { 1250, 1600 }, { 1600, 2000 }, { 2000, 2500 }, { 2500, 3150 } };

        double[] table3_2 = new double[] { 0.1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

    double[,] table3 = new double[,] { { 0.3*0.001, 0.5*0.001,0.8*0.001,1.2*0.001,2*0.001,3*0.001,4*0.001,6*0.001,10*0.001,14*0.001,25*0.001,40*0.001,60*0.001,0.10,0.14,0.25,0.40,0.60,1.00,1.40 },
                                  { 0.4*0.001, 0.6*0.001,1*0.001,1.5*0.001,2.5*0.001,4*0.001,5*0.001,8*0.001,12*0.001,18*0.001,30*0.001,48*0.001,75*0.001,0.12,0.18,0.30,0.48,0.75,1.20,1.80 },
                                  { 0.4*0.001, 0.6*0.001,1*0.001,1.5*0.001,2.5*0.001,4*0.001,6*0.001,9*0.001,15*0.001,22*0.001,36*0.001,58*0.001,90*0.001,0.15,0.22,0.36,0.58,0.90,1.50,2.20},
                                  { 0.5*0.001, 0.8*0.001,1.2*0.001,2*0.001,3*0.001,5*0.001,8*0.001,11*0.001,18*0.001,27*0.001,43*0.001,70*0.001,110*0.001,0.18,0.27,0.43,0.70,1.10,1.80,2.70 },
                                  { 0.6*0.001, 1*0.001,1.5*0.001,2.5*0.001,4*0.001,6*0.001,9*0.001,13*0.001,21*0.001,33*0.001,52*0.001,84*0.001,130*0.001,0.21,0.33,0.52,0.84,1.30,2.10,3.30 },
                                  {  0.6*0.001, 1*0.001,1.5*0.001,2.5*0.001,4*0.001,7*0.001,11*0.001,16*0.001,25*0.001,39*0.001,62*0.001,100*0.001,160*0.001,0.25,0.39,0.62,1.00,1.60,2.50,3.90 },
                                  { 0.8*0.001, 1.2*0.001,2*0.001,3*0.001,5*0.001,8*0.001,13*0.001,19*0.001,30*0.001,46*0.001,74*0.001,120*0.001,190*0.001,0.30,0.46,0.74,1.20,1.90,3.00,4.60 },
                                  { 1*0.001, 1.5*0.001,2.5*0.001,4*0.001,6*0.001,10*0.001,15*0.001,22*0.001,35*0.001,54*0.001,87*0.001,140*0.001,220*0.001,0.35,0.54,0.87,1.40,2.20,3.50,5.40 },
                                  {   1.2*0.001, 2*0.001,3.5*0.001,5*0.001,8*0.001,12*0.001,18*0.001,25*0.001,40*0.001,63*0.001,100*0.001,160*0.001,250*0.001,0.40,0.63,1.00,1.60,2.50,4.00,6.30 },
                                  {  2*0.001, 3*0.001,4.5*0.001,7*0.001,10*0.001,14*0.001,20*0.001,29*0.001,46*0.001,72*0.001,115*0.001,185*0.001,290*0.001,0.46,0.72,1.15,1.85,2.90,4.60,7.20 },
                                  {  2.5*0.001, 4*0.001,6*0.001,8*0.001,12*0.001,16*0.001,23*0.001,32*0.001,52*0.001,81*0.001,130*0.001,210*0.001,320*0.001,0.52,0.81,1.30,2.10,3.20,5.20,8.10 },
                                  {   3*0.001, 5*0.001,7*0.001,9*0.001,13*0.001,18*0.001,25*0.001,36*0.001,57*0.001,89*0.001,140*0.001,230*0.001,360*0.001,0.57,0.89,1.40,2.30,3.60,5.70,8.90 },
                                  {   4*0.001, 6*0.001,8*0.001,10*0.001,15*0.001,20*0.001,27*0.001,40*0.001,63*0.001,97*0.001,155*0.001,250*0.001,400*0.001,0.63,0.97,1.55,2.50,4.00,6.30,9.70 },
                                  {   4.5*0.001, 6*0.001,9*0.001,11*0.001,16*0.001,22*0.001,30*0.001,44*0.001,70*0.001,110*0.001,175*0.001,280*0.001,440*0.001,0.70,1.10,1.75,2.80,4.40,7.00,11.00 },
                                  {  5*0.001, 7*0.001,10*0.001,13*0.001,18*0.001,25*0.001,35*0.001,50*0.001,80*0.001,125*0.001,200*0.001,320*0.001,500*0.001,0.80,1.25,2.00,3.20,5.00,8.00,12.50 },
                                  {   5.5*0.001, 8*0.001,11*0.001,15*0.001,21*0.001,29*0.001,40*0.001,56*0.001,90*0.001,140*0.001,230*0.001,360*0.001,560*0.001,0.90,1.40,2.30,3.60,5.60,9.00,14.00 },
                                  {   6.5*0.001, 9*0.001,13*0.001,18*0.001,24*0.001,34*0.001,46*0.001,66*0.001,105*0.001,165*0.001,260*0.001,420*0.001,660*0.001,1.05,1.65,2.60,4.20,6.60,10.50,16.50 },
                                  {  8*0.001, 11*0.001,15*0.001,21*0.001,29*0.001,40*0.001,54*0.001,78*0.001,125*0.001,195*0.001,310*0.001,500*0.001,780*0.001,1.25,1.95,3.10,5.00,7.80,12.50,19.50 },
                                  { 9*0.001, 13*0.001,18*0.001,25*0.001,35*0.001,48*0.001,65*0.001,92*0.001,150*0.001,230*0.001,370*0.001,600*0.001,920*0.001,1.50,2.30,3.70,6.00,9.20,15.00,23.00 },
                                  {  11*0.001, 15*0.001,22*0.001,30*0.001,41*0.001,57*0.001,77*0.001,110*0.001,175*0.001,280*0.001,440*0.001,700*0.001,1100*0.001,1.75,2.80,4.40,7.00,11.00,17.50,28.00 },
                                  {   13*0.001, 18*0.001,26*0.001,36*0.001,50*0.001,69*0.001,93*0.001,135*0.001,210*0.001,330*0.001,540*0.001,860*0.001,1350*0.001,2.10,3.30,5.40,8.60,13.50,21.00,33.00 }};
            
        public Form1()
           {
               
            
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "вал", "отверстие" });
            comboBox2.Items.AddRange(new string[] { "цилиндрическая", "плоская" });
            comboBox3.Items.AddRange(new string[] { "двухсторонний", "односторонний" });
            comboBox1.SelectedIndex = 0; comboBox2.SelectedIndex = 0; comboBox3.SelectedIndex = 0;
             textBox14.Text = "0";
            tip_det = 1; tip_prip = 1;
            tip_obr_pov = 1; vid_zag = 1;
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "";textBox12.Text = "";
  string lo = "nte20";

            textBox2.Text = Convert.ToString(lo);

    
            xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlpath);

            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(xmlDoc.DocumentElement.Name));

            TreeNode rootNode = new TreeNode();
            rootNode = treeView1.Nodes[0];

            AddNode(xmlDoc.DocumentElement, rootNode);
            
            
            treeView1.CollapseAll();
            rootNode.Toggle();

            int g = rootNode.FirstNode.Index; int r = rootNode.LastNode.Index;
            rootNode = rootNode.FirstNode;
            /*for (int f = g; f <= r; f++)
            { rootNode.Toggle();
                rootNode = rootNode.NextNode;
            }*/
            rootNode = treeView1.Nodes[0];
            
       }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "односторонний") { tip_prip = 2; pictureBox1.Visible = false; pictureBox2.Visible = true; }
            if (comboBox1.Text == "двухсторонний") { tip_prip = 1; pictureBox1.Visible = true; pictureBox2.Visible = false; }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "плоская") { tip_obr_pov = 2; }
            if (comboBox2.Text == "цилиндрическая") { tip_obr_pov = 1; }

        }
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }

            else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox10.Text = f.Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                
                

               try
               {
                    bool pribor = true;
                    if (level == 2)
                    {
                        i++;
                        Array.Resize(ref Rz, i); Array.Resize(ref h, i); Array.Resize(ref T, i); Array.Resize(ref CombInd, i); Array.Resize(ref K, i); Array.Resize(ref E1, i); Array.Resize(ref E, i); Array.Resize(ref prib, i); Array.Resize(ref per, i); Array.Resize(ref id, i); Array.Resize(ref id_per, i);
                        id[i - 1] = sid[0]; Array.Resize(ref Epr, i);
                        id_per[i - 1] = Convert.ToInt32(sid_per);
                        per[i - 1] = Convert.ToString(i - 1) + " - " + textBox9.Text + "(" + textBox8.Text + "," + comboBox5.Text + ")";
                        Rz[i - 1] = Convert.ToDouble(textBox5.Text);
                        h[i - 1] = Convert.ToDouble(textBox6.Text);
                        T[i - 1] = Convert.ToDouble(textBox7.Text);
                        K[i - 1] = Convert.ToDouble(textBox11.Text);
                        richTextBox1.Text = richTextBox1.Text + "," + "\n" + per[i - 1];
                        l = l + "," + "\r\n" + per[i - 1];
                        // textBox1.Text = Convert.ToString(t1[0, 0].Equals(comboBox5.Text));


                        CombInd[i-1] = comboBox5.SelectedIndex;
                        int hh_dlin = hh.Length; int vid_pr = 0; 
                        if (id_per[i - 1] == 0)
                        { prib[i - 1] = " "; }
                        else
                        {
                            prib[i - 1] = comboBox5.Text;
                            try { if (prib[i - 2].Contains(prib[i - 1])) { pribor = false; } else { pribor = true; } }
                            catch { }
                        }
                        if (comboBox5.Text == "не выбрано") { prib[i - 1] = prib[i - 2]; }
                       if (pribor)
                        {
                            switch (Convert.ToInt32(id_per[i - 1]))
                            {
                                case 1:
                                    {

                                        for (int nom1 = mas1[comboBox5.SelectedIndex]; nom1 < mas1[comboBox5.SelectedIndex + 1]; nom1++)
                                        {
                                            hh_dlin = t1[nom1, 1].Length;
                                            for (int nom2 = 0; nom2 < hh_dlin; nom2++)
                                            {
                                                if (t1[nom1, 1][nom2].Equals(id[i - 2]))
                                                {
                                                    // richTextBox1.Text = richTextBox1.Text + Convert.ToString(nom1) + "-" + Convert.ToString(id[i - 2]) + "-" + Convert.ToString(nom2) + "-" + t1[nom1, 1][nom2] + "\n";
                                                    E1[i-1] = nom1;Epr[i-1] = true;
                                                }
                                            }
                                        }
                                       /* for (int nom1 = 0; nom1 < 10; nom1++)
                                        {
                                            if ((t1_diam[0, nom1] <= Convert.ToDouble(perd)) && (t1_diam[1, nom1] > Convert.ToDouble(perd)))
                                            {
                                                E[i - 1] = Convert.ToDouble(t1[E1[i-1], nom1 + 2]);
                                                //textBox10.Text = Convert.ToString(E[i - 1]) + Convert.ToString(E1) + "-" + Convert.ToString(nom1 + 2);
                                            }
                                        }*/
                                        break;
                                    }

                                case 2:
                                    {
                                        for (int nom1 = mas1[comboBox5.SelectedIndex]; nom1 < mas1[comboBox5.SelectedIndex + 1]; nom1++)
                                        {
                                            hh_dlin = t1[nom1, 1].Length;
                                            for (int nom2 = 0; nom2 < hh_dlin; nom2++)
                                            {
                                                if (t1[nom1, 1][nom2].Equals(id[i - 2]))
                                                {
                                                    //richTextBox1.Text = richTextBox1.Text + Convert.ToString(nom1) + "-" + Convert.ToString(id[i - 2]) + "-" + Convert.ToString(nom2) + "-" + t2[nom1, 1][nom2] + "\n";
                                                    E1[i-1] = nom1; Epr[i-1] = true;
                                                }
                                            }
                                        }
                                       /* for (int nom1 = 0; nom1 < 10; nom1++)
                                        {
                                            if ((t1_diam[0, nom1] <= Convert.ToDouble(perd)) && (t1_diam[1, nom1] > Convert.ToDouble(perd)))
                                            {
                                                E[i - 1] = Convert.ToDouble(t1[E1[i-1], nom1 + 2]);
                                                //textBox10.Text = Convert.ToString(E[i - 1]) + Convert.ToString(E1) + "-" + Convert.ToString(nom1 + 2);
                                            }
                                        }*/
                                        break;
                                    }
                                case 0: { E[i - 1] = 0;Epr[i - 1] = false; break; }
                            }
                        }
                        else { E[i - 1] = 0;Epr[i - 1] = false; }




                    }
                }
                catch { }
            
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            level = e.Node.Level;
            comboBox5.Items.Clear(); comboBox5.Text = "";
            try
            {
                if (level == 1)
                { e.Node.Toggle(); }
                if (e.Node.Level == 2)
                {
                    textBox5.Text = "0";
                    textBox6.Text = "0";//Не забыть посмотреть 0 или 1 для формулы
                    textBox7.Text = "0";
                    textBox9.Text = Convert.ToString(e.Node.Parent.Text);
                    textBox8.Text = Convert.ToString(e.Node.Text);
                    textBox7.Text = Convert.ToString(e.Node.FirstNode.FirstNode.Text);
                    string[] S = new string[2];
                        S = e.Node.FirstNode.NextNode.FirstNode.Text.Split(new Char[] { '_' });
                    textBox5.Text = S[0];
                    S=S[1].Split(new Char[] { '-' });
                  
                   
                    Ra_max = Convert.ToDouble( S[1]);Ra_min = Convert.ToDouble(S[0]);

                    Rz_min = Ra_min * 4 / 1000;
                    Rz_max = Ra_max * 4 / 1000;


                    textBox6.Text = Convert.ToString(e.Node.FirstNode.NextNode.NextNode.FirstNode.Text);
                    textBox11.Text = Convert.ToString(e.Node.FirstNode.NextNode.NextNode.NextNode.FirstNode.Text);
                    sid = Convert.ToString(e.Node.FirstNode.NextNode.NextNode.NextNode.NextNode.FirstNode.Text);
                    sid_per = Convert.ToString(e.Node.FirstNode.NextNode.NextNode.NextNode.NextNode.NextNode.FirstNode.Text);
                    comboBox5.Items.Clear();int hhn=0;
                    switch (Convert.ToInt32(sid_per))
                    { case 1: { int nom1 = t1.Length / 12;
                                for(int yu=0;yu< nom1;yu++)
                                { if(t1[yu,0][0]!=' ') {
                                        hhn++; Array.Resize(ref hh, hhn); Array.Resize(ref mas1, hhn);
                                        hh[hhn - 1] = t1[yu, 0]; mas1[hhn - 1] = yu;
                                        comboBox5.Items.Add(t1[yu, 0]); }
                                      }
                                Array.Resize(ref mas1, hhn + 1); mas1[hhn] = nom1+1; comboBox5.Items.RemoveAt(hh.Length-1);
                            } break;
                        case 2:
                            {
                                int nom1 = t1.Length / 12;
                                for (int yu = 0; yu < nom1; yu++)
                                {
                                    if (t1[yu, 0][0] != ' ')
                                    {
                                        hhn++; Array.Resize(ref hh, hhn); Array.Resize(ref mas1, hhn);
                                        hh[hhn - 1] = t1[yu, 0];mas1[hhn - 1] = yu;
                                        comboBox5.Items.Add(t1[yu, 0]); }
                                }
                                Array.Resize(ref mas1, hhn+1);mas1[hhn] = nom1+1;comboBox5.Items.RemoveAt(hh.Length-1);
                            }
                            break;
                       case 0: { per_0 = true; break; }

                          

                    }
                    try { comboBox5.SelectedIndex = 0;  } catch { }

                    /* while(1<2)
                     {
                         try
                         {
                             if (Convert.ToUInt32(sid_per) == 1)
                             { ik[nom1] = t1[0, nom1]; nom1++; }
                             else
                             {
                                 if (Convert.ToUInt32(sid_per) == 2)
                                 { ik[nom1] = t1[0, nom1]; nom1++; }
                             }
                         }

                         catch { break; };

                     }
                     try{
                     comboBox5.Items.AddRange(new string[] {t1[0,0],ik[1],ik[2]});}
                     catch { }*/
                }

        }catch{}

           
            
        }
        

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                f.ShowDialog();
                string j = f.Data;

                split_data = j.Split(new Char[] { '|' });
                this.textBox10.Text = split_data[0];
               
                treeView1.Enabled = true;
                richTextBox1.Enabled = true;
                textBox5.Enabled = true;
                textRa.Enabled = true;
               
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                comboBox5.Enabled = true;
                richTextBox2.Enabled = true;
                buttontext.Enabled = true;
                per[0] = "0 - " + split_data[0];
                richTextBox1.Text = per[0]+"";
                i = 1;
                l= per[0] + "";
                Rz[0] = Convert.ToDouble(split_data[1]); h[0] = Convert.ToDouble(split_data[2]); T[0] = Convert.ToDouble(split_data[3]);
                id[0] = split_data[4][0];
                Pcm= Convert.ToDouble(split_data[5]);
                prib[0] = " ";
                id_per[0] = 0;
              
               
            }
            catch
            { }
 


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (i > 1)
                {
                    i--;
                    richTextBox1.Text = "";
                    l = "";
                    if (i == 1)
                    {

                        richTextBox1.Text = "";
                        l = "";
                        richTextBox1.Text = richTextBox1.Text + per[0];
                        l = l + per[0];
                    }
                    else { 
                    for (int nom = 0; nom <= i-2; nom++)
                    { richTextBox1.Text = richTextBox1.Text + per[nom]+",\n";
                      l=l + per[nom] + ",\r\n";
                        }
                        richTextBox1.Text = richTextBox1.Text + per[i-1] ;
                        l = l + per[i-1] ;
                    }
                }
                
            }
            catch
            { } }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool osh = true;
            try { double u; u = Convert.ToDouble(textBox1.Text); u = Convert.ToDouble(textBox12.Text); }
            catch { osh = false; }
            try
            {
                if ((Convert.ToDouble(textBox12.Text) <= 0) || (Convert.ToDouble(textBox12.Text) >= 3150)) { osh = false; }
                if ((Convert.ToDouble(textBox1.Text) <= 0) || (Convert.ToDouble(textBox1.Text) >= 3150)) { osh = false; }
            }
            catch { }
            if (osh)
            {
              
                //    try
                    {
                        for (int nom2 = 0; nom2 < i; nom2++)
                        {
                            if (Epr[nom2])
                            {
                                double perd = Convert.ToDouble(textBox1.Text);
                                if ((CombInd[nom2] == 5) || (CombInd[nom2] == 4)) { perd = Convert.ToDouble(textBox12.Text);  }

                                for (int nom1 = 0; nom1 < 10; nom1++)
                                {
                                    if ((t1_diam[0, nom1] <= perd) && (t1_diam[1, nom1] > perd))
                                    {
                                        E[nom2] = Convert.ToDouble(t1[E1[nom2], nom1 + 2]);
                                        //textBox10.Text = Convert.ToString(E[i - 1]) + Convert.ToString(E1) + "-" + Convert.ToString(nom1 + 2);

                                    }
                                }
                            }
                            else { E[nom2] = 0; }
                        }







                        Array.Resize(ref L, i); L[i - 1] = Convert.ToDouble(textBox1.Text); int str = 0; Array.Resize(ref Ti, i); Array.Resize(ref Zag, i);
                        for (int nom2 = 0; nom2 < 21; nom2++)
                        {
                            if ((table3_1[nom2, 0] <= L[i - 1]) && (table3_1[nom2, 1] > L[i - 1])) { str = nom2; }
                        }
                        for (int nom1 = 0; nom1 < i; nom1++)
                        {
                            for (int nom2 = 0; nom2 < 20; nom2++)
                            { if (T[nom1] == table3_2[nom2]) { Ti[nom1] = table3[str, nom2]; break; } }
                        }
                      double delt = 1; double Py = 0; double sverl = 1;

                        for (int nom1 = 0; nom1 < 5; nom1++)
                        { if ((t4[0, nom1] <= Convert.ToDouble(textBox1.Text)) && (t4[1, nom1] > Convert.ToDouble(textBox1.Text))) { sverl = t4[2, nom1]; break; } }

                        for (int nom1 = 0; nom1 < 5; nom1++)
                        { if ((t3[0, nom1] <= Convert.ToDouble(textBox1.Text)) && (t3[1, nom1] > Convert.ToDouble(textBox1.Text))) { delt = t3[2, nom1]; break; } }

                        try
                        {
                            if (comboBox1.SelectedIndex == 1)
                            { Py = Convert.ToDouble(textBox14.Text) * sverl; }

                        }
                        catch { }

                        //// округления чисел

                        double LdDouble = Convert.ToDouble(textBox1.Text);
                        Math.Round(LdDouble, 4);
                        textBox1.Text = Convert.ToString(LdDouble);





                        richTextBox2.Text = "Исходные данные: L(d)=" + Convert.ToString(textBox1.Text) + " l=" + Convert.ToString(textBox12.Text) + "\n" + "Параметры: " + comboBox1.Text + ", " + comboBox2.Text + ", " + comboBox3.Text + "." + "\n";
                        l2 = "Исходные данные: L(d)=" + Convert.ToString(textBox1.Text) + " l=" + Convert.ToString(textBox12.Text) + "\r\n" + "Параметры: " + comboBox1.Text + ", " + comboBox2.Text + ", " + comboBox3.Text + "." + "\r\n";
                        for (int nom1 = 0; nom1 < i-1; nom1++)
                        {
                            Array.Resize(ref Td, i);
                            Td[nom1] = Convert.ToString(Ti[nom1]);

                            richTextBox2.Text = richTextBox2.Text + per[nom1] + ":\r\n Rz" + Convert.ToString(nom1) + " = " + Convert.ToString(Rz[nom1]) + " h" + Convert.ToString(nom1) + " = " + Convert.ToString(h[nom1]) + " T" + Convert.ToString(nom1) + " = " + Convert.ToString(Ti[nom1]) + "\r\n";
                            l2 = l2 + per[nom1] + ":\r\n Rz" + Convert.ToString(nom1) + " = " + Convert.ToString(Rz[nom1]) + " h" + Convert.ToString(nom1) + " = " + Convert.ToString(h[nom1]) + " T" + Convert.ToString(nom1) + " = " + Convert.ToString(Ti[nom1]) + "\r\n";
                        }
                    try
                    {
                        if (textBox3.Text == "")
                        {
                            richTextBox2.Text = richTextBox2.Text + per[i-1] + ":\r\n Rz" + Convert.ToString(i - 1) + " = " + Convert.ToString(Rz[i - 1]) + " h" + Convert.ToString(i - 1) + " = " + Convert.ToString(h[i - 1]) + " T" + Convert.ToString(i - 1) + " = " + Convert.ToString(Ti[i - 1]) + "\r\n";
                            l2 = l2 + per[i - 1] + ":\r\n Rz" + Convert.ToString(i - 1) + " = " + Convert.ToString(Rz[i - 1]) + " h" + Convert.ToString(i - 1) + " = " + Convert.ToString(h[i - 1]) + " T" + Convert.ToString(i - 1) + " = " + Convert.ToString(Ti[i - 1]) + "\r\n";
                        }
                        else
                        {
                            Ti[i - 1] = Convert.ToDouble(textBox3.Text);
                            richTextBox2.Text = richTextBox2.Text + per[i - 1] + ":\r\n Rz" + Convert.ToString(i - 1) + " = " + Convert.ToString(Rz[i - 1]) + " h" + Convert.ToString(i - 1) + " = " + Convert.ToString(h[i - 1]) + " T" + Convert.ToString(i - 1) + " = " + Convert.ToString(Ti[i - 1]) + "\r\n";
                            l2 = l2 + per[i - 1] + ":\r\n Rz" + Convert.ToString(i - 1) + " = " + Convert.ToString(Rz[i - 1]) + " h" + Convert.ToString(i - 1) + " = " + Convert.ToString(h[i - 1]) + " T" + Convert.ToString(i - 1) + " = " + Convert.ToString(Ti[i - 1]) + "\r\n";
                        }
                        
                    }
                    catch
                    {
                        richTextBox2.Text = richTextBox2.Text + per[i - 1] + ":\r\n Rz" + Convert.ToString(i - 1) + " = " + Convert.ToString(Rz[i - 1]) + " h" + Convert.ToString(i - 1) + " = " + Convert.ToString(h[i - 1]) + " T" + Convert.ToString(i - 1) + " = " + Convert.ToString(Ti[i - 1]) + "\r\n";
                        l2 = l2 + per[i - 1] + ":\r\n Rz" + Convert.ToString(i - 1) + " = " + Convert.ToString(Rz[i - 1]) + " h" + Convert.ToString(i - 1) + " = " + Convert.ToString(h[i - 1]) + " T" + Convert.ToString(i - 1) + " = " + Convert.ToString(Ti[i - 1]) + "\r\n";
                    }

                    Array.Resize(ref P, i);

                        bool sv = false; for (int nom1 = 1; nom1 < i; nom1++) { if (id[nom1].Equals('8')) { sv = true; break; } }

                        if (sv) { P[0] = Convert.ToDouble(textBox14.Text) * sverl; }
                        else
                        {
                            if ((id[0].Equals('1') || (id[0].Equals('6')) || (id[0].Equals('7'))))
                            { P[0] = Convert.ToDouble(textBox12.Text) * 0.005; }
                            else { P[0] = Math.Sqrt((Math.Pow((Convert.ToDouble(textBox12.Text) * delt), 2) + Math.Pow(Pcm, 2))); }
                        }


                        richTextBox2.Text = richTextBox2.Text + "Составляющие припуска p для каждого перехода:";
                        l2 = l2 + "Составляющие припуска p для каждого перехода:";
                        richTextBox2.Text = richTextBox2.Text + "\r\n" + "P" + Convert.ToString(0) + " = " + P[0];
                        l2 = l2 + "\r\n" + "P" + Convert.ToString(0) + " = " + P[0];
                        for (int nom1 = 1; nom1 < i - 1; nom1++)
                        {
                            P[nom1] = P[0] * K[nom1];

                            richTextBox2.Text = richTextBox2.Text + "\r\n" + "P" + Convert.ToString(nom1) + " = " + P[nom1];
                            l2 = l2 + "\r\n" + "P" + Convert.ToString(nom1) + " = " + P[nom1];
                        }
                        richTextBox2.Text = richTextBox2.Text + "\r\n" + "Составляющие припуска E для каждого перехода:";




                        l2 = l2 + "\r\n" + "Составляющие припуска E для каждого перехода:";
                        for (int nom1 = 1; nom1 < i; nom1++)
                        {
                            richTextBox2.Text = richTextBox2.Text + "\r\n" + "E" + Convert.ToString(nom1) + " = " + E[nom1];
                            l2 = l2 + "\r\n" + "E" + Convert.ToString(nom1) + " = " + E[nom1];
                        }
                        Array.Resize(ref Zmin, i);
                        richTextBox2.Text = richTextBox2.Text + "\r\n" + "Величины минимального припуска для каждого перехода:";
                        l2 = l2 + "\r\n" + "Величины минимального припуска для каждого перехода:";
                        Array.Resize(ref ZminDouble, i);


                        ///my  
                        Array.Resize(ref Zmind, i - 1);
                        ///

                        for (int nom1 = 1; nom1 < i; nom1++)
                        {
                            if (comboBox2.SelectedIndex == 1) { Zmin[nom1] = Rz[nom1 - 1] + h[nom1 - 1] + P[nom1 - 1] + E[nom1]; } else { Zmin[nom1] = Rz[nom1 - 1] + h[nom1 - 1] + Math.Sqrt((Math.Pow(P[nom1 - 1], 2) + Math.Pow(E[nom1], 2))); }


                            // Округление 
                            Zmin[nom1] = Math.Round(Zmin[nom1], 4);
                            /// my
                            Zmind[nom1 - 1] = Convert.ToString(Zmin[nom1]);

                            richTextBox2.Text = richTextBox2.Text + "\r\n" + "Zmin" + Convert.ToString(nom1) + " = " + Zmin[nom1];
                            l2 = l2 + "\r\n" + "Zmin" + Convert.ToString(nom1) + " = " + Zmin[nom1];

                        }
                        Array.Resize(ref Znom, i); richTextBox2.Text = richTextBox2.Text + "\r\n" + "Величины номинального припуска для каждого перехода:";
                        l2 = l2 + "\r\n" + "Величины номинального припуска для каждого перехода:";
                        for (int nom1 = 1; nom1 < i; nom1++)
                        {
                            if (comboBox3.SelectedIndex == 0)
                            {
                                Znom[nom1] = 2 * Zmin[nom1] + Ti[nom1 - 1];

                                // Округление 
                                Znom[nom1] = Math.Round(Znom[nom1], 4);

                                richTextBox2.Text = richTextBox2.Text + "\r\n" + "2Znom" + Convert.ToString(nom1) + " = " + Znom[nom1];
                                l2 = l2 + "\r\n" + "2Znom" + Convert.ToString(nom1) + " = " + Znom[nom1];
                            }
                            else
                            {
                                Znom[nom1] = Zmin[nom1] + Ti[nom1 - 1];
                                // Округление 
                                Znom[nom1] = Math.Round(Znom[nom1], 4);
                                richTextBox2.Text = richTextBox2.Text + "\r\n" + "Znom" + Convert.ToString(nom1) + " = " + Znom[nom1];
                                l2 = l2 + "\r\n" + "Znom" + Convert.ToString(nom1) + " = " + Znom[nom1];
                            }

                        }

                        ///my
                        Array.Resize(ref Tdd, i);
                        int fivv = 0;

                    
                        if (comboBox1.SelectedIndex == 0)
                        {
                            for (int nom1 = i - 1; nom1 > 0; nom1--)
                            {
                                L[nom1 - 1] = L[nom1] + Znom[nom1];



                                // Округление 
                                try
                                {
                                    string StrTi = Convert.ToString(Ti[nom1]);
                                    string[] StrTi1 = StrTi.Split(',');
                                    int Kol = Convert.ToInt32(StrTi1[1].Length);
                                    L[nom1] = Math.Round(L[nom1], Kol);
                                }
                                catch { L[nom1] = Math.Round(L[nom1], 0); }

                                Tdd[nom1] = Convert.ToString(L[nom1]);
                                fivv++;
                                ///

                                richTextBox2.Text = richTextBox2.Text + "\r\n" + "d" + Convert.ToString(nom1) + " = " + Convert.ToString(L[nom1]) + "(-" + Convert.ToString(Ti[nom1]) + ")";
                                l2 = l2 + "\r\n" + "d" + Convert.ToString(nom1) + " = " + Convert.ToString(L[nom1]) + "(-" + Convert.ToString(Ti[nom1]) + ")";
                            }

                            ///
                            // Округление 
                            try
                            {
                                string StrTi0 = Convert.ToString(Ti[0]);
                                string[] StrTi10 = StrTi0.Split(',');
                                int Kol0 = Convert.ToInt32(StrTi10[1].Length);
                                L[0] = Math.Round(L[0], Kol0);
                            }
                            catch { L[0] = Math.Round(L[0], 0); }


                            richTextBox2.Text = richTextBox2.Text + "\r\n" + "d" + Convert.ToString(0) + " = " + Convert.ToString(L[0]) + "(-" + Convert.ToString(Ti[0]) + ")";
                            l2 = l2 + "\r\n" + "d" + Convert.ToString(0) + " = " + Convert.ToString(L[0]) + "(-" + Convert.ToString(Ti[0]) + ")";
                        }
                        else
                        {
                            for (int nom1 = i - 1; nom1 > 0; nom1--)
                            {
                                L[nom1 - 1] = L[nom1] - Znom[nom1];


                                /// L - d ,Ti - Допуск   
                                // Округление 
                                try
                                {
                                    string StrTi = Convert.ToString(Ti[nom1]);
                                    string[] StrTi1 = StrTi.Split(',');
                                    int Kol = Convert.ToInt32(StrTi1[1].Length);
                                    L[nom1] = Math.Round(L[nom1], Kol);
                                }
                                catch { L[nom1] = Math.Round(L[nom1], 0); }
                                Tdd[nom1] = Convert.ToString(L[nom1]);


                                richTextBox2.Text = richTextBox2.Text + "\r\n" + "d" + Convert.ToString(nom1) + " = " + Convert.ToString(L[nom1]) + "(+" + Convert.ToString(Ti[nom1]) + ")";
                                l2 = l2 + "\r\n" + "d" + Convert.ToString(nom1) + " = " + Convert.ToString(L[nom1]) + "(+" + Convert.ToString(Ti[nom1]) + ")";
                            }
                            // Округление 
                            try
                            {
                                string StrTi0 = Convert.ToString(Ti[0]);
                                string[] StrTi10 = StrTi0.Split(',');
                                int Kol0 = Convert.ToInt32(StrTi10[1].Length);
                           L[0] = Math.Round(L[0], Kol0);
}
                            catch { L[0] = Math.Round(L[0], 0); }
                            richTextBox2.Text = richTextBox2.Text + "\r\n" + "d" + Convert.ToString(0) + " = " + Convert.ToString(L[0]) + "(+" + Convert.ToString(Ti[0]) + ")";
                            l2 = l2 + "\r\n" + "d" + Convert.ToString(0) + " = " + Convert.ToString(L[0]) + "(+" + Convert.ToString(Ti[0]) + ")";
                        }
                        /* for (int nom1 = i - 1; nom1 > 0; nom1--)
                         { Zag[nom1] = L[nom1] + Ti[nom1];

                         // Округление 
                         Zag[nom1] = Math.Round(Zag[nom1], 4);

                         richTextBox2.Text = richTextBox2.Text + "\r\n" + "Размер после " + Convert.ToString(nom1) + "-го перехода" + " L" + Convert.ToString(nom1) + " = " + Convert.ToString(Zag[nom1]);
         l2=l2  +"\r\n" + "Размер после " + Convert.ToString(nom1) + "-го перехода" + " L" + Convert.ToString(nom1) + " = " + Convert.ToString(Zag[nom1]);
                         } Zag[0] = L[0] + Ti[0];
                         int zagot = Convert.ToInt32(Zag[0]);
                         if (zagot < Zag[0]) { zagot++; }

                         // Округление 
                         double zagotD = Convert.ToDouble(zagot);
                         zagotD = Math.Round(zagotD, 4);
                         richTextBox2.Text = richTextBox2.Text + Environment.NewLine + "Размер заготовки " + "L" + Convert.ToString(0) + " = " + Convert.ToString(zagot) + "\r\n";
                         l2=l2+ Environment.NewLine + "Размер заготовки " + "L" + Convert.ToString(0) + " = " + Convert.ToString(zagot) + "\r\n";*/

                        if (comboBox1.SelectedIndex == 0) { tip = 0; };
                        if (comboBox1.SelectedIndex == 1) { tip = 1; };


                        richTextBoxtoForm2.Text = richTextBox2.Text + "|" + i + "|" + l2 + "|" + tip + "|" + Convert.ToString(L[0]);



                        // Добавление d
                        for (int nom1 = i - 1; nom1 > 0; nom1--)
                        { richTextBoxtoForm2.Text = (richTextBoxtoForm2.Text + "|" + Tdd[nom1]); }








                        // Добавление Td (Ti)
                        for (int nom1 = i - 1; nom1 >= 0; nom1--)
                        {
                            //     Td                Convert.ToString(Ti[nom1])
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "|" + Ti[nom1];
                        }
                        richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "#";

                        richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + Convert.ToString(i) +"$"+ Convert.ToString(textBox12.Text) +"$"+ Convert.ToString(textBox1.Text) + "$" + "" + "$" + "" + "$" + "" + "$" + Convert.ToString(comboBox1.Text) + "$" + Convert.ToString(comboBox2.Text) + "$" + Convert.ToString(comboBox3.Text) + "$" + per[0] ;
                       // textBox2.Text = per[2];

                        for (int nom1 = 1; nom1 < i; nom1++)
                        {
                            
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + per[nom1];
                        }

                        for (int nom1 = 0; nom1 < i; nom1++)
                        {

                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(Rz[nom1]);
                        }
    

                        for (int nom1 = 0; nom1 < i; nom1++)
                        {
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(h[nom1]);
                        }
                        for (int nom1 = 0; nom1 < i; nom1++)
                        {
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(P[nom1]);
                        }
                        for (int nom1 = 0; nom1 < i; nom1++)
                        {
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(E[nom1]);
                        }
                        for (int nom1 = 0; nom1 < i; nom1++)
                        {
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(Ti[nom1]);
                        }

                        for (int nom1 = 0; nom1 < i; nom1++)
                        {
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(Znom[nom1]);
                        }
                        for (int nom1 = 0; nom1 < i; nom1++)
                        {
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(L[nom1]);
                        }

                        richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(Pcm);


                        for (int nom1 = 1; nom1 < i; nom1++)
                        {
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(K[nom1]);
                        }
                        for (int nom1 = 0; nom1 < i; nom1++)
                        {
                            richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(T[nom1]);
                        }

                                       //// ID
                                          for (int nom1 = 0; nom1 < i; nom1++)
                                          {
                                                                                          richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(id[nom1]);
                                          }
                                          ////   id приспособления
                                          for (int nom1 = 0; nom1 < i; nom1++)
                                          {
                                              richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + Convert.ToString(CombInd[nom1]);
                                          }
                                          richTextBoxtoForm2.Text = richTextBoxtoForm2.Text + "$" + textBox14.Text; 

                        /// квалитет - Т
                      //  textBox2.Text = Convert.ToString(i);
                        /// открываем 3 форму
                        Form3 Z = new Form3(this.richTextBoxtoForm2.Text);
                        Z.ShowDialog();
                    }


                 //   catch
           //         {
            //            MessageBox.Show("Введены некорректные данные");
           //        }







                }
               else { MessageBox.Show("Введены некорректные данные", "Ошибка"); }
       

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox1);
        }
      

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            CheckCommas.checkCommas(textBox5);

            // Для Ra 
            try
            {
                if (textBox5.Text == "") { textBox5.Text = "0"; };
                textRa.Text = Convert.ToString((Convert.ToDouble(textBox5.Text)) / 4 * 1000);
            }
            catch { }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox6);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox7);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox11);
        }

       

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox14);
        }

        private void buttontext_Click(object sender, EventArgs e)
        {

            System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"textfile.txt");
        //Последовательность переходов

            textFile.WriteLine();
            textFile.WriteLine("Последовательность переходов");
            textFile.WriteLine(l);
            
            // Исходые данные
            textFile.WriteLine();
            textFile.WriteLine("");
            textFile.WriteLine(l2);
            //
            textFile.Close();
        
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { textBox14.Visible = false; label17.Visible = false; } else { label17.Visible = true; textBox14.Visible = true; }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            //  Hide();
            z.ShowDialog();
            treeView1.Enabled = true;
            richTextBox1.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox11.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            comboBox5.Enabled = true;
            richTextBox2.Enabled = true;
            buttontext.Enabled = true;
            stroka = z.Data;

            split_data1 = stroka.Split(new Char[] { '-' });
           

            textBox1.Text = split_data1[1]; textBox12.Text = split_data1[0];
            per[0] = "0 - " + split_data1[2];
            Rz[0] = Convert.ToDouble(split_data1[3]); h[0] = Convert.ToDouble(split_data1[4]); T[0] = Convert.ToDouble(split_data1[5]);
            id[0] = split_data1[7][0];
            Pcm = Convert.ToDouble(split_data1[6]);
            prib[0] = " ";
            id_per[0] = 0;
            richTextBox1.Text = per[0] + "";
           
            l = per[0] + "";

            i = Convert.ToInt32(split_data1[8]);
            Array.Resize(ref Rz, i); Array.Resize(ref h, i); Array.Resize(ref T, i); Array.Resize(ref CombInd, i); Array.Resize(ref per, i); Array.Resize(ref K, i); Array.Resize(ref E1, i); Array.Resize(ref E, i); Array.Resize(ref prib, i); Array.Resize(ref per, i); Array.Resize(ref id, i); Array.Resize(ref id_per, i); Array.Resize(ref Epr, i);
            int hhn = 0; Epr[0] = false; CombInd[0] = 0;
            int nom1 = t1.Length / 12;
            for (int yu = 0; yu < nom1; yu++)
            {
                if (t1[yu, 0][0] != ' ')
                {
                    hhn++; Array.Resize(ref hh, hhn); Array.Resize(ref mas1, hhn);
                    hh[hhn - 1] = t1[yu, 0]; mas1[hhn - 1] = yu;

                }
            }



            for (int u = 1; u < i; u++)
            {
                
                   
                Rz[u] = Convert.ToDouble(split_data1[10 + (7 * (u - 1))]);
                h[u] = Convert.ToDouble(split_data1[11 + (7 * (u - 1))]);
                T[u] = Convert.ToDouble(split_data1[12 + (7 * (u - 1))]);
                K[u] = Convert.ToDouble(split_data1[13 + (7 * (u - 1))]);
                CombInd[u] = Convert.ToInt32(split_data1[14 + (7 * (u - 1))]);
                id[u]=(split_data1[15 + (7 * (u - 1))])[0];
                if (CombInd[u] == 0) { CombInd[u] = CombInd[u - 1]; }
                if (CombInd[u] == CombInd[u - 1]) { Epr[u] = false; } else { Epr[u] = true; }
                prib[u] = hh[CombInd[u]];
                split_data2 = split_data1[9 + (7 * (u - 1))].Split(new Char[] { ',' });
                per[u] = Convert.ToString(u) + " - " + split_data2[0] + "(" + split_data2[1] + "," + prib[u]+")";
                richTextBox1.Text = richTextBox1.Text + "," + "\n" + per[u];
                l = l + "," + "\r\n" + per[u];
            }
            
                for (int u = 1; u < i; u++)
                {
                    for (nom1 = mas1[CombInd[u]]; nom1 < mas1[CombInd[u] + 1]; nom1++)
                    {
                        int hh_dlin = t1[nom1, 1].Length;
                        for (int nom2 = 0; nom2 < hh_dlin; nom2++)
                        {
                            if (t1[nom1, 1][nom2].Equals(id[u - 1]))
                            {
                                
                                E1[u] = nom1;
                            }
                        }
                    }
                
            }
           
            

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void открытьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //  Hide();
                z.ShowDialog();
                treeView1.Enabled = true;
                richTextBox1.Enabled = true;
                textBox5.Enabled = true;
        
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                comboBox5.Enabled = true;
                richTextBox2.Enabled = true;
                textRa.Enabled = true;
                buttontext.Enabled = true;
                stroka = z.Data;

                split_data1 = stroka.Split(new Char[] { '-' });


                textBox1.Text = split_data1[1]; textBox12.Text = split_data1[0];
                per[0] = "0 - " + split_data1[2]; textBox10.Text = split_data1[2];
                Rz[0] = Convert.ToDouble(split_data1[3]); h[0] = Convert.ToDouble(split_data1[4]); T[0] = Convert.ToDouble(split_data1[5]);
                id[0] = split_data1[7][0];
                Pcm = Convert.ToDouble(split_data1[6]);
                prib[0] = " ";
                id_per[0] = 0;
                richTextBox1.Text = per[0] + "";

                l = per[0] + "";

                i = Convert.ToInt32(split_data1[8]) - 1;
                Array.Resize(ref Rz, i); Array.Resize(ref h, i); Array.Resize(ref T, i); Array.Resize(ref CombInd, i); Array.Resize(ref per, i); Array.Resize(ref K, i); Array.Resize(ref E1, i); Array.Resize(ref E, i); Array.Resize(ref prib, i); Array.Resize(ref per, i); Array.Resize(ref id, i); Array.Resize(ref id_per, i); Array.Resize(ref Epr, i);
                int hhn = 0; Epr[0] = false; CombInd[0] = 0;
                int nom1 = t1.Length / 12;
                for (int yu = 0; yu < nom1; yu++)
                {
                    if (t1[yu, 0][0] != ' ')
                    {
                        hhn++; Array.Resize(ref hh, hhn); Array.Resize(ref mas1, hhn);
                        hh[hhn - 1] = t1[yu, 0]; mas1[hhn - 1] = yu;

                    }
                }



                for (int u = 1; u < i; u++)
                {


                    Rz[u] = Convert.ToDouble(split_data1[10 + (7 * (u - 1))]);
                    h[u] = Convert.ToDouble(split_data1[11 + (7 * (u - 1))]);
                    T[u] = Convert.ToDouble(split_data1[12 + (7 * (u - 1))]);
                    K[u] = Convert.ToDouble(split_data1[13 + (7 * (u - 1))]);
                    CombInd[u] = Convert.ToInt32(split_data1[14 + (7 * (u - 1))]);
                    id[u] = (split_data1[15 + (7 * (u - 1))])[0];
                    if (CombInd[u] == 0) { CombInd[u] = CombInd[u - 1]; }
                    if (CombInd[u] == CombInd[u - 1]) { Epr[u] = false; } else { Epr[u] = true; }
                    prib[u] = hh[CombInd[u]];
                    split_data2 = split_data1[9 + (7 * (u - 1))].Split(new Char[] { ',' });
                    per[u] = Convert.ToString(u) + " - " + split_data2[0] + "(" + split_data2[1] + "," + prib[u] + ")";
                    richTextBox1.Text = richTextBox1.Text + "," + "\n" + per[u];
                    l = l + "," + "\r\n" + per[u];
                }
                //    h[u] = Convert.ToDouble(split_data1[11 + (7 * (u - 1))]);
                string tip_det = split_data1[11 + (7 * (i - 1))];

                if (tip_det.Contains("двухсторонний"))
                { comboBox3.SelectedIndex = 0;      }

                else { comboBox3.SelectedIndex = 1;           }
                tip_det = split_data1[10 + (7 * (i - 1))];



                if (tip_det.Contains("цилиндрическая"))
                { comboBox2.SelectedIndex = 0; }
                else { comboBox2.SelectedIndex = 1; }
                tip_det = split_data1[9 + (7 * (i - 1))];


                if (tip_det.Contains("вал"))
                { comboBox1.SelectedIndex = 0; }
                else { comboBox1.SelectedIndex = 1; }
                textBox14.Text = split_data1[12 + (7 * (i - 1))];
                for (int u = 1; u < i; u++)
                {
                    for (nom1 = mas1[CombInd[u]]; nom1 < mas1[CombInd[u] + 1]; nom1++)
                    {
                        int hh_dlin = t1[nom1, 1].Length;
                        for (int nom2 = 0; nom2 < hh_dlin; nom2++)
                        {
                            if (t1[nom1, 1][nom2].Equals(id[u - 1]))
                            {

                                E1[u] = nom1;
                            }
                        }
                    }

                }


            }
            catch
            {
                treeView1.Enabled = false;
                richTextBox1.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                comboBox5.Enabled = false;
                richTextBox2.Enabled = false;
                textRa.Enabled = false;
                buttontext.Enabled = false;
            }
            
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Длина детали";
            toolTip1.SetToolTip(textBox12, "Введите длину детали");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Размер Диаметр";
            toolTip1.SetToolTip(textBox1, "Размер Диаметр");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Тип размера";
            toolTip1.SetToolTip(comboBox1, "Тип размера");
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Тип припуска";
            toolTip1.SetToolTip(comboBox3, "Двухсторонний: обрабатываются вал, отверстие, противолежащие поверхности. \nОдносторонний: получаемый размер задаётся от необрабатываемой поверхности.");
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;

            toolTip1.ToolTipTitle = "Тип обрабатываемой поверхности";
            toolTip1.SetToolTip(comboBox2, "Фасонные замкнутые поверхности следует рассматривать как цилиндрические, фасонные незамкнутые – как плоские.");
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Тип приспособления";
            toolTip1.SetToolTip(comboBox5, "Тип приспособления");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int nom = textBox3.Text.Length;
                if (textBox3.Text[nom - 1].Equals('.')) { textBox3.Text = textBox3.Text.Replace('.', ','); textBox3.SelectionStart = nom; }
           //     if (textBox3.Text[nom - 1].Equals('-')) { textBox3.Text = textBox3.Text.Replace('-', '' ); textBox3.SelectionStart = nom; }
            //    if (textBox3.Text[nom - 1].Equals('+')) { textBox3.Text = textBox3.Text.Replace('+', '' ); textBox3.SelectionStart = nom; }


            }
            catch { }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCommas.checkString(e);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCommas.checkString(e);
        }

        private void textRa_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textRa);
            // Для Rz 
            try
            {
                if (textRa.Text == "")
                {
                    textRa.Text = "0";
                };
                textBox5.Text = Convert.ToString((Convert.ToDouble(textRa.Text)) * 4 / 1000);
            }
            catch { }

          
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "двухсторонний") { pictureBox1.Visible = true; pictureBox2.Visible = false; };
            if (comboBox3.Text == "односторонний") { pictureBox1.Visible = false; pictureBox2.Visible = true; };
        }

        private void textBox5_Click(object sender, EventArgs e)
       {
             toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Достигаемая шероховатость, Rz, мм";
            toolTip1.SetToolTip(textBox5, "Интервал для данной операции: " + Convert.ToString(Rz_min) + "..." + Convert.ToString(Rz_max));
        }

        private void textRa_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Достигаемая шероховатость, Ra, мкм";
            toolTip1.SetToolTip(textRa, "Интервал для данной операции: " + Convert.ToString(Ra_min) + "..." + Convert.ToString(Ra_max));
        }
    }
               
           



        }
        

        

        
    

