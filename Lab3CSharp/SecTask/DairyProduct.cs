using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp.SecTask
{
    internal class DairyProduct : FoodProduct
    {
        protected string origin;

        public DairyProduct(string name, double price, int shelfLife, string origin) : base(name, price, shelfLife)
        {
            this.origin = origin;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Country = {origin} ");
        }
    }
}
