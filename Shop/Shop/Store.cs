using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Store
    {
        private Article article;

        public Article GetArticle
        {
            get
            {
                return article;
            }
        }
        public Store(){ }

        public Store(Article article)
        {
            this.article = article;
        }
    }
}
