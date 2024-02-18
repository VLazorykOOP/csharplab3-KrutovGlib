using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp.SecTask
{
    internal class Toy : Product
    {
        protected string category;
        public Toy(string name, double price, string category) : base(name, price)
        {
            this.category = category;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Category = {category}");
        }
    }
}
