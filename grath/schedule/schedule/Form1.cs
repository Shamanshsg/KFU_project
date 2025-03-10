using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule
{
    public partial class Form1 : Form
    {
        bool tp = true;
        bool inter = false;
        bool st = true;
        int sp = 1000;
        int min;
        int max;
        int value = 1;
        List<double> listX = new List<double>();
        List<int> listY = new List<int>();
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            Speed.Text = sp.ToString();
            textValue.Text = value.ToString();
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Value";

        }

        private  void start_Click(object sender, EventArgs e)
        {
            st = true;
            stopwatch.Start();
            listX.Clear();
            listY.Clear();
            chart1.Series[0].Points.Clear();
            var t = new Thread(chart);
            t.Start();
            stopwatch.Stop();
        }

        private void chart()
        {
            while (st)
            {

                Thread.Sleep(sp);
                TimeSpan ts = stopwatch.Elapsed;
                listX.Add(ts.Seconds);
                listY.Add(value);

                this.BeginInvoke((Action)(() =>
                {
                    if (inter)
                    {
                        chart1.ChartAreas[0].AxisX.Minimum = min;
                        
                    }
                    else
                    {
                        chart1.ChartAreas[0].AxisX.Minimum = 0;
                    }
                    chart1.Series[0].Points.DataBindXY(listX.ToArray(), listY.ToArray());
                }));
                
            }
        }

        private void type_Click(object sender, EventArgs e)
        {
            if (tp)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                tp = false;
            }
            else
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                tp = true;
            }
        }

        private void MinMax_Click(object sender, EventArgs e)
        {
            if (textMin.Text.Length > 0) 
            {
                min = Convert.ToInt32(textMin.Text);
                inter = true;
            }
            else
            {
                inter = false;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            textValue.Text = (Convert.ToInt32(textValue.Text) + 1).ToString();
            value = Convert.ToInt32(textValue.Text);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            textValue.Text = (Convert.ToInt32(textValue.Text) - 1).ToString();
            value = Convert.ToInt32(textValue.Text);
        }

        private void textValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToInt32(textValue.Text);
            }
            catch { }
            
        }

        private void SpeedUp_Click(object sender, EventArgs e)
        {
            Speed.Text = (Convert.ToInt32(Speed.Text) + 100).ToString();
            sp = Convert.ToInt32(Speed.Text);
        }

        private void SpeedDown_Click(object sender, EventArgs e)
        {
            
            if (sp > 100)
            {
                Speed.Text = (Convert.ToInt32(Speed.Text) - 100).ToString();
                sp = Convert.ToInt32(Speed.Text);
            }

        }

        private void Speed_TextChanged(object sender, EventArgs e)
        {
            sp = Convert.ToInt32(Speed.Text);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            st = false;
        }
    }
}
