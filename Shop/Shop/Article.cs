using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Article
    {
        private string name;
        private string shop;
        private int price;

        public Article() { }

        public Article(string name, string shop, int price)
        {
            this.name = name;
            this.shop = shop;
            this.price = price;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Shop
        {
            get
            {
                return shop;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
        }
    }
}
