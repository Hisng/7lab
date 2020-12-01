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
using System.Windows.Threading;

namespace Array
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nvalue = 0;
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(N.Text) > 0 && nvalue != Convert.ToInt32(N.Text))
                {
                    Odd.Text = "";
                    var rand = new Random();
                    int[] array = new int[Convert.ToInt32(N.Text)];
                    for (int i = 0; i < Convert.ToInt32(N.Text); i++)
                    {
                        array[i] = rand.Next(-1000, 1000);
                    }
                    for(int i = 0; i < array.Length; i++)
                    {
                        if(array[i] % 2 == 1)
                        {
                            Odd.Text += Convert.ToInt32(array[i]) + " ";
                        }
                    }
                    nvalue = Convert.ToInt32(N.Text);
                    Max.Text = Convert.ToString(array.Max());
                    Min.Text = Convert.ToString(array.Min());
                    Sum.Text = Convert.ToString(array.Sum());
                    Average.Text = Convert.ToString(array.Average());
                    
                }
            }
            catch { }    
        }
    }
}
