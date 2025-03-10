using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsMubaNet1
{
    public partial class Form3 : Form
    {
        double t = 0.5;
        int w;
        double varianseSgl;
        double[][] arr;
        public Form3(double[][] data, double varianse)
        {
            InitializeComponent();

            chartfinal.ChartAreas[0].AxisY.Minimum = 0.3;
            chartfinal.ChartAreas[0].AxisY.Maximum = 0.6;

            w = data.Length;
            varianseSgl = varianse;
            textBoxom.Text = Math.Round(varianseSgl, 3).ToString();
            arr = new double[data.Length][];
            data.CopyTo(data, 0);
            arr = sort(data);
            Series0();
            Series1();
            Series2();
        }

        private void Series0()
        {
            int[] x = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                x[i] = i;
            }
            double[] y = new double[arr.Length];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = Math.Round(arr[i][2] / arr[i][1], 3);
            }

            chartfinal.Series[2].Points.DataBindXY(x, y);
        }

        private void Series1()
        {
            int[] x = new int[w];
            for (int i = 0; i < w; i++)
            {
                x[i] = i;
            }
            double[] y = new double[w];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = t;
            }
            chartfinal.ChartAreas[0].AxisX.Minimum = 0;
            chartfinal.Series[1].Points.DataBindXY(x, y);
        }

        private void Series2()
        {
            Random rnd = new Random();
            double[] gl = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                gl[i] = arr[i][2] / arr[i][1];
            }
            int[] x = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                x[i] = i;
            }
            double[] y = new double[arr.Length];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = Math.Round(gl[i] + (rnd.NextDouble() * 2 * varianseSgl) - varianseSgl, 3);
            }

            chartfinal.Series[0].Points.DataBindXY(x, y);
        }

        private double[][] sort(double[][] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i; j < data.Length; j++)
                {
                    if (data[i][3] > data[j][3])
                    {
                        double[] temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
            return data;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void up_buttonom_Click(object sender, EventArgs e)
        {
            varianseSgl += 0.001;
            textBoxom.Text = Math.Round(varianseSgl, 3).ToString();
            Series2();
        }

        private void down_buttonom_Click(object sender, EventArgs e)
        {
            varianseSgl -= 0.001;
            textBoxom.Text = Math.Round(varianseSgl, 3).ToString();
            Series2();
        }

        private void up_buttont_Click(object sender, EventArgs e)
        {
            t += 0.01;
            textBoxt.Text = t.ToString();
            Series1();

        }

        private void down_buttont_Click(object sender, EventArgs e)
        {
            t -= 0.01;
            textBoxt.Text = t.ToString();
            Series1();
        }


    }
}
