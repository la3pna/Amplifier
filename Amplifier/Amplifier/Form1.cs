﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amplifier
{
    public partial class Form1 : Form
    {
        float R1, R2, R3, Vcc, Veb, R_c, beta;
        double Vb,Rth,Ie;

        float Idss, Id, Vp, Vdss, Vdd, Rb, Rdc, Zout; 
        double Rs, Gm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TraCalBias();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            TraCalBias();
        }

        private void TraCalBias()
        {
            try
            {
                 R2 = float.Parse(textBox4.Text);
                 R1 = float.Parse(textBox6.Text);
                 R3 = float.Parse(textBox9.Text);
                 Veb = float.Parse(textBox2.Text);
               beta = float.Parse(textBox1.Text);
                R_c = float.Parse(textBox3.Text);
                Vcc = float.Parse(textBox7.Text);

                Vb = Math.Round( Vcc*(R2)/((R1+R_c)+R2),2);
                label3.Text = Convert.ToString(notation.ToEngineeringNotation(Vb));

                Rth = Math.Round(((R1+R_c)*R2/(R1+R_c+R2)),2);
                label2.Text = Convert.ToString(notation.ToEngineeringNotation(Rth));

                Ie =((Vcc*R2-Veb*((R1+R_c)+R2))*(beta+1))/((R2+(R1+R_c))*R3*(beta+1)+(R1+R_c)*R2);
                label6.Text = "Ie= " + Convert.ToString(notation.ToEngineeringNotation(Ie)) + "A";
            }
            catch
            {
            }
 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TraCalBias();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TraCalBias();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TraCalBias();
        }

        private void CalFBA()
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            calfetR();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            calfetR();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
        private void calfetR()
        {
            try
            {
                Vdd = float.Parse(textBox15.Text);
                Idss = float.Parse(textBox11.Text);
                Id = float.Parse(textBox12.Text);
                Vp = float.Parse(textBox13.Text);
                Rb = float.Parse(textBox17.Text);
                Rdc = float.Parse(textBox14.Text);
                Zout = float.Parse(textBox16.Text);

                Rs = ((Vp / Id) * (Math.Sqrt(Id / Idss) - 1))-Rdc;
                Gm = ((-2.0 * Idss)/Vp)*(1+((Id*Rs)/Vp));

                label29.Text = Convert.ToString(notation.ToEngineeringNotation(Rs));
                label33.Text = Convert.ToString(notation.ToEngineeringNotation(Gm));
                float Isig = (float)Gm;
                float Vout = Isig * Zout;
                double Vz = Math.Sqrt(Zout / 50) * Vout;
                double Vinz = Math.Sqrt(Rb / 50) * 1.0;
                double gaindB = 20.0* Math.Log10(Vz/Vinz);
                label34.Text = Convert.ToString(notation.ToEngineeringNotation(gaindB));

            }
            catch
            {
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            calfetR();
        }


    }
    

}
