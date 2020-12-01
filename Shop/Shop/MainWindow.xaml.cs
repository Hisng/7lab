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

namespace Shop
{
    
    public partial class MainWindow : Window
    {
        List<Store> goods = new List<Store>() { };
        Store store;
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
                for(int i = 0; i < goods.Count(); i++)
                {
                    if (Convert.ToString(goods[i].GetArticle.Name) == Convert.ToString(SearchBox.Text))
                    {
                        NameBox_Copy.Text = goods[i].GetArticle.Name;
                        ShopBox_Copy.Text = goods[i].GetArticle.Shop;
                        PriceBox_Copy.Text = Convert.ToString(goods[i].GetArticle.Price);
                        i = 0;
                    }
                    else if (Convert.ToInt32(SearchBox.Text) <= goods.Count())
                    {
                        NameBox_Copy.Text = goods[Convert.ToInt32(SearchBox.Text) - 1].GetArticle.Name;
                        ShopBox_Copy.Text = goods[Convert.ToInt32(SearchBox.Text) - 1].GetArticle.Shop;
                        PriceBox_Copy.Text = Convert.ToString(goods[Convert.ToInt32(SearchBox.Text) - 1].GetArticle.Price);
                    }
                }
                  
                
            }
            catch
            {
                NameBox_Copy.Text = "";
                ShopBox_Copy.Text = "";
                PriceBox_Copy.Text = "";
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Article article = new Article(Convert.ToString(NameBox.Text), Convert.ToString(ShopBox.Text), Convert.ToInt32(PriceBox.Text));
                store = new Store(article);
                goods.Add(store);
                //MessageBox.Show(Convert.ToString(goods.Count()));
            }
            catch                
            {

            }
        }
    }
}
