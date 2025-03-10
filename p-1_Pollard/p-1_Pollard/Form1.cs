using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;

namespace p_1_Pollard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BigInteger N, E, P, Q, D, Iterations, FI;
        int b;
        String Time, SW;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                N = correct(textBox1.Text);
                E = correct(textBox2.Text);
                SW = correct(textBox3.Text).ToString();
                b = int.Parse(numericUpDown1.Value.ToString());
            }
            else MessageBox.Show("заполните все поля");

            try
            {
                textBox9.Text = Crack();
                textBox4.Text = P.ToString();
                textBox5.Text = Q.ToString();
                textBox6.Text = D.ToString();
                textBox7.Text = Iterations.ToString();
                textBox8.Text = Time;
            }
            catch { MessageBox.Show("ошибочка!"); }

        }

        private BigInteger correct(string text)
        {
            BigInteger res = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == false)
                {
                    MessageBox.Show("введите число");
                    res = 0;
                    break;
                }
                else BigInteger.TryParse(text, out res);
            }
            return res;
        }

        public string Crack()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            P = p1_pollard(N);
            stopwatch.Stop();
            Time = stopwatch.Elapsed.ToString();
            Q = N / P;
            FI = (P - 1) * (Q - 1);
            D = Set_D(FI, E);
            return Decrypt(SW, D, N);
        }

        public BigInteger p1_pollard(BigInteger n)
        {
            int b1 = b;
            List<int> p = Euratosphen(2,b1);
            List<int> q = Euratosphen(b1, b1 * b1);
            BigInteger c;
            BigInteger d;
            BigInteger a = 2;
            List<int> Diff = DiffQ(q);
            BigInteger M = Count_M(b1, p);
            a = BigInteger.ModPow(a, M, N);
            BigInteger gcd = BigInteger.GreatestCommonDivisor(N, a-1);
            if (gcd == 1)
            {
               c = BigInteger.ModPow(a, q[0], N);
               d = BigInteger.GreatestCommonDivisor(N, c - 1);
                if (d != 1)
                    return d;
                if (d==1)
                {
                    while (d == 1)
                    {
                        for (int i = 0; i < Diff.Count; i++)
                        {
                            c = (c * BigInteger.ModPow(a, Diff[i], N)) % N;
                            d = BigInteger.GreatestCommonDivisor(N, c - 1);
                            Iterations++;
                            if (d != 1)
                                return d;
                        }
                        return d;
                    }
                }
                else
                {
                    return d;
                }

            }
            else
            { 
                return gcd;
            }
            return 1;
        }

        private BigInteger Count_M(int b1, List<int>simple)
        {
            List<int> temp = new List<int>();
            BigInteger M=1;
            foreach (int i in simple)
            { 
                temp.Add(i);
            }
            for(int i=0;i<simple.Count;i++)
            {
                while (simple[i] * temp[i] < b1)
                {
                    simple[i] *= temp[i];
                }
            }
            foreach(int i in simple)
            {
                M *= i;
            }
            return M;
        }

        private static List<int> DiffQ(List<int> simple)
        {
            List<int> dif = new List<int>();
            for (int i = 0; i < simple.Count - 1; i++)
            {
                dif.Add(simple[i + 1] - simple[i]);
            }
            return dif;
        }

        private List<int> Euratosphen(int from, int to)
        {
            List<int> simple = new List<int>();
            bool[] range = new bool[to + 1];
            for (int i = 2; i < to + 1; i++)
            {
                range[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(to + 1) + 1; ++i)
            {
                if (range[i])
                {
                    for (int j = i * i; j < to + 1; j += i)
                    {
                        range[j] = false;
                    }
                }
            }
            for (int i = from; i < to + 1; i++)
            {
                if (range[i])
                    simple.Add(i);
            }
            return simple;
        }

        private BigInteger Set_D(BigInteger fi, BigInteger exp)
        {
            var (nod, x, y) = evklid(fi, exp);
            return y > 0 ? y : y + fi;
        }

        public string Decrypt(string message, BigInteger d, BigInteger N)
        {
            string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмнопрстуфхцчшщъыьэюя";
            int offset = 16;
            string result = string.Empty;


            BigInteger temp = BigInteger.Parse(message);
            temp = BigInteger.ModPow(temp, d, N);
            while (temp != 0)
            {
                int tmp = Int32.Parse((temp % 100).ToString());
                temp /= 100;
                result += alphabet[(tmp - offset) % alphabet.Length];
            }
            result = Reverse(result);
            return result;

        }
        private string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private (BigInteger, BigInteger, BigInteger) evklid(BigInteger A, BigInteger B)
        {
            BigInteger nod;
            BigInteger x;
            BigInteger y;
            if (A == 0)
            {
                return (B, 0, 1);
            }
            else
            {
                (nod, x, y) = evklid(B % A, A);
            }
            return (nod, y - (B / A) * x, x);
        }
    }
}
