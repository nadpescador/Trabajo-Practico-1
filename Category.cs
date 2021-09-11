using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
namespace Trabajo_Practico_1
{
    class Category : IComparable<Category>
    {
        public int id { get; set; }
        public String name { get; set; }

        public Category(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public int CompareTo(Category other)
        {
            return name.CompareTo(other.name);
        }
    }
}