using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_Lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ran, av, var, empav, empvar, errorav, errorvar, chi;

        Random r = new Random();

        double[] prob;
        double[] freq;
        int[] stat;
        int N;

        private void btStart_Click(object sender, EventArgs e)
        {
            prob = new double[5];
            stat = new int[5];
            freq = new double[5];
            N = (int)edN.Value;
            prob[0] = (double)ed1.Value;
            prob[1] = (double)ed2.Value;
            prob[2] = (double)ed3.Value;
            prob[3] = (double)ed4.Value;
            prob[4] = 1;

            for (int i = 0; i < 4; i++) prob[4] -= prob[i];
            tb5.Text = prob[4].ToString();

            for (int i = 0; i < N; i++)
            {
                ran = r.NextDouble();
                double sum = 0;
                for (int k = 0; k < 5; k++)
                {
                    sum += prob[k];
                    if (ran <= sum)
                    {
                        stat[k]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < 5; i++) freq[i] = stat[i] / (double)N;
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 5; i++) chart1.Series[0].Points.AddXY(i + 1, freq[i]);

            for (int i = 0; i < 5; i++)
            {
                av += (i + 1) * prob[i];
                var += (i + 1) * (i + 1) * prob[i] - ((i + 1) * prob[i]) * ((i + 1) * prob[i]);
                empav += (i + 1) * freq[i];
                empvar += (i + 1) * (i + 1) * freq[i] - ((i + 1) * freq[i]) * ((i + 1) * freq[i]);
                chi += stat[i] * stat[i] / ((double)N * prob[i]);
            }

            chi = Math.Round(chi - (double)N, 2);
            errorav = Math.Round(Math.Abs(empav - av) * 100 / av, 1);
            errorvar = Math.Round(Math.Abs(empvar - var) * 100 / var, 1);
            tbAv.Text = empav.ToString();
            tbVar.Text = empvar.ToString();
            tbEAr.Text = errorav.ToString() + "%";
            tbEVar.Text = errorvar.ToString() + "%";
            tbChi.Text = chi.ToString();
            if (chi > 9.488) tbTrue.Text = ">    9.488 верно";
            else tbTrue.Text = ">    9.488 неверно";
        }

        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
