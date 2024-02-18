using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp.SecTask
{
    internal class Product
    {
        protected string name;
        protected double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public double Price => price;

        public virtual void Show()
        {
            Console.WriteLine($"Name = {name}, Price = {price}");
        }

        
    }
}
