using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp.SecTask
{
    internal class FoodProduct : Product
    {
        protected int ShelfLife;
        public FoodProduct(string name, double price, int shelfLife) : base(name, price)
        {
            ShelfLife = shelfLife;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Shelf Life = {ShelfLife}");
        }
    }
}
