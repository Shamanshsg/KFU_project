using System.Drawing;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace formsMubaNet1
{
    public partial class Form1 : Form
    {
        double[][] arr;
        const int max_w = 100;
        double t = 0.5;
        double varianseSgl;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Random rnd = new Random();
        private void ImportData(DataGridView sender)
        {
            if (sender.Columns.Count == 0)
            {
                string[] name = new string[6] { "id", "height", "weight", "glucose level", "diabetes", "bmi" };
                for (int i = 0; i < name.Length; i++)
                {
                    sender.Columns.Add(name[i], name[i]);
                    sender.Columns[i].Width = 50;
                }
            }
            for (int j = 0; j < arr.Length; j++)
            {
                sender.Rows.Add(arr[j][0], arr[j][1], arr[j][2], arr[j][3], arr[j][4], arr[j][5]);
                if ((arr[j][5] < 14 || arr[j][5] > 40))
                {
                    sender.Rows[j].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void removeAll(DataGridView sender)
        {
            int v = sender.RowCount;
            for (int i = 0; i < v - 1; i++)
            {
                sender.Rows.RemoveAt(0);
            }
        }

        private double[][] GenerateArr()
        {
            double[][] arr = new double[max_w][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new double[6];
                arr[i][0] = i;
                arr[i][1] = rnd.Next(165, 250);
                arr[i][2] = rnd.Next(62, 100);
                arr[i][5] = Math.Round(arr[i][2] / Math.Pow((arr[i][1] / 100), 2), 2);
            }
            return arr;
        }

        private void glucose()
        {
            double[] gl = new double[arr.Length];
            double meangl = 0;
            varianseSgl = 0;

            for (int i = 0;i < arr.Length;i++)
            {
                gl[i] = arr[i][2] / arr[i][1];
                meangl += gl[i];
            }
            meangl /= arr.Length;

            for (int i = 0; i < arr.Length;i++)
            {
                varianseSgl += Math.Pow(gl[i] - meangl, 2);
            }
            varianseSgl /= arr.Length;

            for(int i = 0; i < arr.Length;i++)
            {
                arr[i][3] =Math.Round(gl[i] + (rnd.NextDouble() * 2 * varianseSgl) - varianseSgl, 3);
            }

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            arr = GenerateArr();
            ImportData(dataGrid);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
            ImportData(dataGridClear);

        }

        private void Clear()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i][5] < 14 || arr[i][5] > 40)
                {
                    arr[i][1] = rnd.Next(165, 250);
                    arr[i][2] = rnd.Next(62, 100);
                    arr[i][5] = Math.Round(arr[i][2] / Math.Pow((arr[i][1] / 100), 2), 2);
                }
            }
        }

        private void isHeal()
        {
            for(int i = 0;i < arr.Length;i++)
            {
                if (arr[i][3] >= t) arr[i][4] = 1;
                else arr[i][4] = 0;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonChart_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(arr);
            form2.Show();
        }

        private void RemoveData1_Click(object sender, EventArgs e)
        {
            removeAll(dataGrid);
        }

        private void RemoveData2_Click(object sender, EventArgs e)
        {
            removeAll(dataGridClear);
        }

        private void GenerateG_Click(object sender, EventArgs e)
        {
            glucose();
            ImportData(dataGridgl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            removeAll(dataGridgl);
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            isHeal();
            ImportData(dataGridHeal);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart_button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(arr, varianseSgl);
            form3.Show();
        }
    }
}