using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace formsMubaNet1
{
    public partial class Form2 : Form
    {
        public Form2(double[][] arr)
        {
            InitializeComponent();
            double[][] data = new double[arr.Length][];
            arr.CopyTo(data, 0);
            data = sort(data);
            Chart1(data);
            bar(data);
        }

        private void Chart1(double[][] data)
        {

            double[] x = new double[data.Length];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = data[i][1];
            }
            double[] y = new double[data.Length];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = data[i][2];
            }

            chart1.ChartAreas[0].AxisY.Minimum = y.Min();
            chart1.ChartAreas[0].AxisY.Maximum = y.Max();
            chart1.Series[0].Points.DataBindXY(x, y);
        }

        private double[][] sort(double[][] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[i][1] > arr[j][1])
                    {
                        double[] temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        private void bar(double[][] data)
        {
            double[] xdata = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                xdata[i] =Math.Round(data[i][2] / data[i][1], 3);
            }
            Array.Sort(xdata);
            int k = (data.Length / 10) - 1;
            double delta = (xdata.Max() - xdata.Min()) / k;
            int index = 0;

            double[] x = new double[k];
            double[] y = new double[k];


            x[0] =Math.Round(xdata.Min() - delta / 2, 3);
            x[k - 1] = Math.Round(xdata.Max() + delta / 2, 3);
            for (int i = 1; i < x.Length - 1; i++)
            {
                x[i] = Math.Round(x[i - 1] + delta, 3);
            }
            for (int i = 0; i < x.Length; i++)
            {
                int count = 0;
                while (index < xdata.Length && xdata[index] < x[i])
                {
                    count++;
                    index++;
                }
                y[i] = count;
            }
            bar1.ChartAreas[0].AxisY.Minimum = y.Min();
            bar1.ChartAreas[0].AxisY.Maximum = y.Max();
            bar1.Series[0].Points.DataBindXY(x, y);
        }
    }
}
