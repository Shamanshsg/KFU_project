using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace factorization
{

    public partial class MainWindow : Window
    {
        int lim = 10000;
        bool bf = false;
        bool br = false;
        bool bl = true;
        public MainWindow()
        {
            InitializeComponent();
            limit.Text = lim.ToString();
        }

        private void FermaButton_Click(object sender, RoutedEventArgs e)
        {
            if (bl)
            {
                bf = true;
                int a = 2;
                StringBuilder temp = new StringBuilder("2");
                for (int p = 3; p < lim; p++)
                {
                    if (pow(a, p - 1, p) == 1)
                    {
                        temp.Append(" ");
                        temp.Append(p.ToString());
                    }
                }
                Ferma.Text = temp.ToString();
            }
        }


        private bool check ()
        {
            BigInteger keyTemp;
            if (BigInteger.TryParse(limit.Text, out keyTemp)) return true;
            else return false;

        }

        private int Euclid (int a, int b)
        {
            if (a == b) return a;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return b;

        }


        private BigInteger pow (BigInteger value, BigInteger pow, BigInteger mod)
        {
            BigInteger result = 1;
            while (pow > 0)
            {
                if (pow % 2 == 1)
                {
                    result = (result * value) % mod;

                }
                value = (value * value) % mod;
                pow /= 2;
            }
            return result;
        }

        private void sieveButton_Click(object sender, RoutedEventArgs e)
        {
            if (bl)
            {
                br = true;
                bool[] mas = new bool[lim];
                mas[0] = true;
                mas[1] = true;
                for (int i = 2; Math.Pow(i, 2) < lim; i++)
                {
                    if (!mas[i])
                    {
                        for (int i1 = Convert.ToInt32(Math.Pow(i, 2)); i1 < lim; i1 = i1 + i)
                        {
                            mas[i1] = true;
                        }
                    }
                }
                StringBuilder temp = new StringBuilder();
                for (int i = 0; i < mas.Length; i++)
                {
                    if (!mas[i])
                    {
                        temp.Append(i);
                        temp.Append(" ");
                    }
                }
                sieve.Text = temp.ToString();
            }
        }

        private void compare_Click(object sender, RoutedEventArgs e)
        {
            if (br && bf)
            {
                string[] ferma = Ferma.Text.Split(' ');
                string[] siev = sieve.Text.Split(' ');
                StringBuilder temp = new StringBuilder();
                int f = 0;
                int s = 0;
                while (s < siev.Length && f < ferma.Length)
                {
                    if (Convert.ToInt32(ferma[f]) != Convert.ToInt32(siev[s]))
                    {
                        temp.Append(ferma[f]);
                        temp.Append(" ");
                        f++;
                    }
                    f++;
                    s++;
                }
                res.Text = temp.ToString();
            }
        }

        private void limit_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (check())
            {
                lim = Convert.ToInt32(limit.Text);
                Error.Content = "";
                bl = true;
            }
            else
            {
                Error.Content = "БУКВЫ В ПОЛЕ СВЕРХУ!!!";
                bl = false;
            }
        }
    }
}
