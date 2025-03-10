using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RSA_DECRYPTION
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private static BigInteger gcd(BigInteger a, BigInteger b)
        {
            BigInteger c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
        Func<BigInteger, BigInteger> g = x => x * x + 1;

        private void Rho(BigInteger a, BigInteger b, BigInteger n) {
            BigInteger x = a;
            BigInteger y = 2;
            while(gcd(BigInteger.Abs(y - x), n) == 1 || gcd(BigInteger.Abs(y - x), n) == n)
            {
                x = g(x) % b;
                y = g(g(y) % b) % b;
            }
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate ()
            {
                p.Text = gcd(BigInteger.Abs(y - x), n).ToString();
                q.Text = (n / gcd(BigInteger.Abs(y - x), n)).ToString();
            }
            );
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            BigInteger mod = BigInteger.Parse(n.Text);
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Task[] tsks =
            {
                Task.Run(() => Rho(2, mod / 3, mod)),
                Task.Run(() => Rho(mod / 3, 2 * mod / 3, mod)),
                Task.Run(() => Rho(2 * mod / 3, mod, mod))
            };
            await Task.WhenAny(tsks);
            stopwatch.Stop();
            time.Content = "Time: " + stopwatch.ElapsedMilliseconds + "ms";
        }
    }
}