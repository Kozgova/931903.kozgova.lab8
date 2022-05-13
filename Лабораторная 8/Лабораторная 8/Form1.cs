using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_8
{
    public partial class Form1 : Form
    {
        
        double[] pfreq = new double[5] { 0, 0, 0, 0, 0 }; 
        double prob5;

        public Form1()
        {
            InitializeComponent();
            lb1.Text = "";
            lb2.Text = "";
            ed1.ValueChanged += new System.EventHandler(this.ed1_ValueChanged);
            ed2.ValueChanged += new System.EventHandler(this.ed2_ValueChanged);
            ed3.ValueChanged += new System.EventHandler(this.ed3_ValueChanged);
            ed4.ValueChanged += new System.EventHandler(this.ed4_ValueChanged);
        }

        private void btStart1_Click(object sender, EventArgs e)
        {
            double p = 0.5;
            Random rnd = new Random();
            double a = rnd.NextDouble();
            if (textBox1.Text != "")
            {
                if (a < p)
                {
                    lb1.Text = "Да";
                }
                else
                {
                    lb1.Text = "Нет";
                }

            }
         
        }

        private void btStart2_Click(object sender, EventArgs e)
        {
            double[] p = new double[6] { 0.1, 0.2, 0.1, 0.2, 0.2, 0.2 };
            Random rnd = new Random();
            double a = rnd.NextDouble();
            if (textBox2.Text != "")
            {
                if ((0 <= a) && (a < p[0]))
                {
                    lb2.Text = "Нет";
                }

                if ((p[0] <= a) && (a < (p[0] + p[1])))
                {
                    lb2.Text = "Скорее нет";
                }

                if (((p[0] + p[1]) <= a) && (a < (p[0] + p[1] + p[2])))
                {
                    lb2.Text = "Возможно не стоит";
                }

                if (((p[0] + p[1] + p[2]) <= a) && (a < (p[0] + p[1] + p[2] + p[3])))
                {
                    lb2.Text = "Возможно стоит";
                }

                if (((p[0] + p[1] + p[2] + p[3]) <= a) && (a < (p[0] + p[1] + p[2] + p[3] + p[4])))
                {
                    lb2.Text = "Скорее да";
                }

                if (((p[0] + p[1] + p[2] + p[3] + p[4]) <= a) && (a <= (p[0] + p[1] + p[2] + p[3] + p[4] + p[5])))
                {
                    lb2.Text = "Да";
                }

            }
        }

        private void btStart3_Click(object sender, EventArgs e)
        {
            int number = (int)edAmount.Value;
            int[] events = new int[5] { 0, 0, 0, 0, 0 };
            double[] freq = new double[5] { 0, 0, 0, 0, 0 };

            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {

                double s = rnd.NextDouble();


                if ((0 <= s) && (s < pfreq[0]))
                {
                    events[0] = events[0] + 1;
                }

                if ((pfreq[0] <= s) && (s < (pfreq[0] + pfreq[1])))
                {
                    events[1] = events[1] + 1;
                }

                if (((pfreq[0] + pfreq[1]) <= s) && (s < (pfreq[0] + pfreq[1] + pfreq[2])))
                {
                    events[2] = events[2] + 1;
                }

                if (((pfreq[0] + pfreq[1] + pfreq[2]) <= s) && (s < (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3])))
                {
                    events[3] = events[3] + 1;
                }

                if (((pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]) <= s) && (s < (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3] + pfreq[4])))
                {
                    events[4] = events[4] + 1;
                }

            }

            for (int i = 0; i < 5; i++)
            {
                freq[i] = (double)events[i] / number;
                Console.WriteLine(freq[i]);
                chart1.Series[0].Points.AddXY(i, freq[i]);
            }
        }

        private void ed1_ValueChanged(Object sender, EventArgs e)
        {
            pfreq[0] = (double)ed1.Value;
            prob5 = 1 - (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]);
            ed5.Text = Math.Round(prob5, 3).ToString();
            if (prob5 < 0)
            {
                ed5.ForeColor = Color.Red;
                btStart3.Enabled = false;
            }
            else
            {
                ed5.ForeColor = Color.Black;
                btStart3.Enabled = true;
            }
            pfreq[4] = prob5;
        }

        private void ed2_ValueChanged(Object sender, EventArgs e)
        {
            pfreq[1] = (double)ed2.Value;
            prob5 = 1 - (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]);
            ed5.Text = Math.Round(prob5, 3).ToString();
            if (prob5 < 0)
            {
                ed5.ForeColor = Color.Red;
                btStart3.Enabled = false;
            }
            else
            {
                ed5.ForeColor = Color.Black;
                btStart3.Enabled = true;
            }
            pfreq[4] = prob5;
        }

        private void ed3_ValueChanged(Object sender, EventArgs e)
        {
            pfreq[2] = (double)ed3.Value;
            prob5 = 1 - (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]);
            ed5.Text = Math.Round(prob5, 3).ToString();
            if (prob5 < 0)
            {
                ed5.ForeColor = Color.Red;
                btStart3.Enabled = false;
            }
            else
            {
                ed5.ForeColor = Color.Black;
                btStart3.Enabled = true;
            }
            pfreq[4] = prob5;
        }

        private void ed4_ValueChanged(Object sender, EventArgs e)
        {
            pfreq[3] = (double)ed4.Value;
            prob5 = 1 - (pfreq[0] + pfreq[1] + pfreq[2] + pfreq[3]);
            ed5.Text = Math.Round(prob5, 3).ToString();
            if (prob5 < 0)
            {
                ed5.ForeColor = Color.Red;
                btStart3.Enabled = false;
            }
            else
            {
                ed5.ForeColor = Color.Black;
                btStart3.Enabled = true;
            }
            pfreq[4] = prob5;
        }
    }
    
}
