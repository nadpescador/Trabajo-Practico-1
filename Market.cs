using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Practico_1
{
    class Market
    {
        public List<Product> products { get; set; }
        public List<User> users { get; set; }
        public List<Category> categories { get; set; }
        public int maxCategories { get; set; }
        public int cantCategories { get; set; }
        public List<Purchase> shopping { get; set; }

        public Market(List<Product> products, List<User> users, List<Category> categories, int maxCategories, int cantCategories, List<Purchase> shopping)
        {
            this.products = products;
            this.users = users;
            this.categories = categories;
            this.maxCategories = maxCategories;
            this.cantCategories = cantCategories;
            this.shopping = shopping;
        }
    }
}
