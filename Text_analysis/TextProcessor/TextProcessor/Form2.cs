using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessor
{
    public partial class Form2 : Form
    {
        private string str;
        private Dictionary<char, int> dic;
        public Form2(Dictionary<char, int> d, string s)
        {
            dic = d;
            str = s;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (dic != null)
            {
                foreach (var item in dic)
                {
                    bar_graph.Series[0].Points.AddXY(item.Key.ToString(), item.Value);
                }
                bar_graph.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            }

            if (str != String.Empty)
            {
                string[] words = Form1.format(str).Split(Form1.separsw);
                int maxl = 0;
                int minl = int.MaxValue;
                foreach (string word in words)
                {
                    if (word.Length > maxl)
                    {
                        maxl = word.Length;
                    }
                    if (word.Length < minl)
                    {
                        minl = word.Length;
                    }
                }

                for (int j = minl; j <= maxl; j++)
                {
                    int temp = 0;
                    for (int i = 0; i < words.Length; i++)
                    {

                        if(words[i].Length == j)
                        {
                            temp++;
                        }
                    }
                    chartWord_letter.Series[0].Points.AddXY(j, temp);
                    chartWord_letter.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                }


                string[] sentences = str.Split(Form1.separs, StringSplitOptions.RemoveEmptyEntries);
                int[] wins = new int[sentences.Length];
                for (int i = 0; i < sentences.Length; i++)
                {
                    wins[i] = sentences[i].Split(Form1.separsw, StringSplitOptions.RemoveEmptyEntries).Length;
                }
                
                int max = wins.Max();
                int min = wins.Min();

                for(int i = min; i <= max; i++)
                {
                    int temp = 0;
                    for(int j = 0; j < wins.Length; j++)
                    {
                        if (wins[j] == i) {
                            temp++;
                        }
                    }
                    
                    chartSentence_letter.Series[0].Points.AddXY(i, temp);
                }
                chartWord_letter.Series[0].BorderWidth = 3;
                chartSentence_letter.Series[0].BorderWidth = 3;
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chartSentence_letter_Click(object sender, EventArgs e)
        {

        }
    }
}
