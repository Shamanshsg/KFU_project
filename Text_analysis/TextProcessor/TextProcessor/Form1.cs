using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextProcessor
{ 


    public partial class Form1 : Form
    {
        Dictionary<char, int> dic;

        public static char[] separs = { '\n', '.', '!', '?', };
        public static char[] separsw = { ',', '\n', '\t', '.', ' ', '!', '?', ';', ':', '-', '–' };
        public static string format(string s)
        {
            return string.Join(" ", s.Split(separsw, StringSplitOptions.RemoveEmptyEntries));
        }
        public bool islet(char s)
        {
            if (Convert.ToInt32(s) == 39)
            {
                return true;
            }
            else
            {
                return char.IsLetter(s);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextInput.Text != String.Empty)
            {
                int count = 0;
                string[] sentences = TextInput.Text.Split(separs, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < sentences.Length; i++)
                {
                    count += format(sentences[i]).Split(separsw).Length;
                }
                count /= sentences.Length;
                Count.Text = count.ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TextInput.Text = String.Empty;
        }

        private void Words_Click(object sender, EventArgs e)
        {
            if (TextInput.Text != String.Empty)
            {
                string str = TextInput.Text;
                string[] words = format(str).Split(separsw);
                Count.Text = words.Length.ToString();
            }
        }

        private void Letters_Click(object sender, EventArgs e)
        {
            if (TextInput.Text != String.Empty)
            {
                Count.Text = TextInput.Text.Count(char.IsLetter).ToString();
            }
        }

        private void Setntence_Click(object sender, EventArgs e)
        {
            if (TextInput.Text != String.Empty)
            {
                Count.Text = TextInput.Text.Split(separs, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TextInput.Text != String.Empty)
            {
                string str = TextInput.Text;
                string[] words = format(str).Split(separsw);
                Count.Text = words.Length.ToString();

                int count = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    count += words[i].Length;
                }
                count /= words.Length;
                Count.Text = count.ToString();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            dic = new Dictionary<char, int>();
            string str = TextInput.Text;
            if (str != string.Empty)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLetter(str[i]))
                    {
                        if (dic.ContainsKey(str[i]))
                        {
                            dic[str[i]]++;
                        }
                        else
                        {
                            dic.Add(str[i], 1);
                        }
                    }
                }
                TextOutput.Items.Clear();
                foreach (var item in dic)
                {
                    TextOutput.Items.Add($"{item.Key}: {item.Value}");
                }
            }
            else
            {
                dic.Clear();
                TextOutput.Items.Clear();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Save Text";
                dlg.Filter = "jpg files (*.txt)|*.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter writer = new StreamWriter(dlg.FileName))
                    {
                        string[] a = TextInput.Text.Split('\n');
                        foreach (string str in a)
                        {
                            writer.WriteLine(str);
                        }
                        
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.txt)|*.txt";
                string line;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(dlg.FileName);
                    line = sr.ReadLine();

                    while (line != null)
                    {
 
                        TextInput.Text += string.Format(line + "\n");

                        line = sr.ReadLine();
                    }

                    sr.Close();
                    

                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 x = new Form2(dic, TextInput.Text);
            x.Show();
        }

        private void lng_Click(object sender, EventArgs e)
        {
            if (TextInput.Text != String.Empty)
            {
                string str = TextInput.Text;
                string[] words = format(str).Split(separsw);
                string lng = string.Empty;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > lng.Length)
                    {
                        lng = words[i];
                    }
                }
                Count.Text = lng;
            }
        }
    }
}
