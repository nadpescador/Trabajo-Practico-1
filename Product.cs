using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Trabajo_Practico_1
{
    class Product : IComparable<Product>
    {
        public String id { get; set; }
        public String name { get; set; }
        public double price { get; set; }
        public int ammount { get; set; }
        public Category category { get; set; }

        public Product(String id, String name, double price, int ammount, Category category)
        {
            this.id = id; 
            this.name = name;
            this.price = price;
            this.ammount =ammount;
            this.category = category;
        }

        public int CompareTo( Product other)
        {
            return name.CompareTo(other.name);
        }
    }
}
