using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace enigma
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rot1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
        string rot2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
        string rot3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
        string refl = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
        int c1 = 0, c2 = 0, c3 = 0;


        private void letter_Click(object sender, RoutedEventArgs e)
        {
            enigma((sender as Button).Name[0] - 'A'); //Нажатие на кнопку
        }

        List<string> comstring = new List<string>();

        void enigma(int input)
        {
            richTextBox1.Text += alph[input];
            input = comstring[input][1] - 'A';

            c1 = Convert.ToInt16(textBox3.Text.ToUpper()[0]) - Convert.ToInt16('A');
            c2 = Convert.ToInt16(textBox2.Text.ToUpper()[0]) - Convert.ToInt16('A');
            c3 = Convert.ToInt16(textBox1.Text.ToUpper()[0]) - Convert.ToInt16('A');
            colorStepOne();
            c1 = (c1 + 1) % 26; 
            textBox3.Text = alph[c1].ToString();
            if (c1 == 0)
            {
                c2 = (c2 + 1) % 26;
                textBox2.Text = alph[c2].ToString();
                if (c2 == 0)
                {
                    c3 = (c3 + 1) % 26;
                    textBox1.Text = alph[c3].ToString();
                }
            }
            int a1 = (input + c1) % 26; //Начало прохода по роторам
            int a2 = ((Convert.ToInt32(rot1[a1]) - 'A') + c2 - c1 + 26) % 26;
            int a3 = ((Convert.ToInt32(rot2[a2]) - 'A') + c3 - c2 + 26) % 26;
            int a4 = ((Convert.ToInt32(rot3[a3]) - 'A') - c3 + 26) % 26;
            int b1 = ((Convert.ToInt32(refl[a4]) - 'A') + c3 + 26) % 26; //Комутатор

            b1 = Convert.ToInt32(rot3.IndexOf(alph[b1])); //Обход по роторам в обратною сторону

            int b2 = ((Convert.ToInt32(alph[b1]) - 'A') - c3 + c2 + 26) % 26;

            b2 = Convert.ToInt32(rot2.IndexOf(alph[b2]));

            int b3 = ((Convert.ToInt32(alph[b2]) - 'A') - c2 + c1 + 26) % 26;

            b3 = Convert.ToInt32(rot1.IndexOf(alph[b3]));

            int b4 = ((Convert.ToInt32(alph[b3]) - 'A') - c1 + 26) % 26;
            richTextBox2.Text += comstring[b4][1];


            colorLite(b4);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                com1 = Convert.ToInt16(textbox4.Text.ToUpper()[0]) - Convert.ToInt16('A');
                com2 = Convert.ToInt16(textbox5.Text.ToUpper()[0]) - Convert.ToInt16('A');

                comstring[comstring[com1][1] - 'A'] = alph[comstring[com1][1] - 'A'].ToString() + alph[comstring[com1][1] - 'A'];
                comstring[com1] = alph[com1].ToString() + alph[com1];
                comstring[comstring[com2][1] - 'A'] = alph[comstring[com2][1] - 'A'].ToString() + alph[comstring[com2][1] - 'A'];
                comstring[com2] = alph[com2].ToString() + alph[com2];

                comstring[com1] = alph[com1].ToString() + alph[com2];
                comstring[com2] = alph[com2].ToString() + alph[com1];

                richTextBox3.Text = null;
                foreach (string i in comstring)
                {
                    richTextBox3.Text += i[0] + " - " + i[1] + '\n';
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void colorStepOne()
        {
            lamp11.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp24.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp22.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp13.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp14.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp15.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp16.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp9.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp17.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp18.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp27.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp26.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp25.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp10.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp19.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp12.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp8.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp23.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp21.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp20.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
            lamp7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#808080")); ;
        }

        private void colorLite(int b4)
        {
            if (b4 == 0) lamp11.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 1) lamp24.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 2) lamp22.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 3) lamp13.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 4) lamp4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 5) lamp14.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 6) lamp15.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 7) lamp16.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 8) lamp9.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 9) lamp17.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 10) lamp18.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 11) lamp27.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 12) lamp26.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 13) lamp25.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 14) lamp10.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 15) lamp19.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 16) lamp2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 17) lamp5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 18) lamp12.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 19) lamp6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 20) lamp8.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 21) lamp23.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 22) lamp3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 23) lamp21.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 24) lamp20.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
            if (b4 == 25) lamp7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#fff829"));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox3.Text = alph[(alph.IndexOf(textBox3.Text) + 1) % alph.Length].ToString();
        }

        private void upRot2_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = alph[(alph.IndexOf(textBox2.Text) + 1) % alph.Length].ToString();
        }

        private void upRot3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = alph[(alph.IndexOf(textBox1.Text) + 1) % alph.Length].ToString();
        }

        private void downRot1_Click(object sender, RoutedEventArgs e)
        {
            textBox3.Text = alph[(alph.IndexOf(textBox3.Text) - 1 + alph.Length) % alph.Length].ToString();
        }

        private void downRot2_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = alph[(alph.IndexOf(textBox2.Text) - 1 + alph.Length) % alph.Length].ToString();
        }

        private void downRot3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = alph[(alph.IndexOf(textBox1.Text) - 1 + alph.Length) % alph.Length].ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            richTextBox3.Text = null;
            comstring = new();
            foreach (char i in alph)
            {
                comstring.Add(i.ToString() + i);
                richTextBox3.Text += i + " - " + i + '\n';
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (char i in alph)
            {
                comstring.Add(i.ToString() + i);
                richTextBox3.Text += i + " - " + i + '\n';
            }
        }
        int com1, com2;
    }
}

