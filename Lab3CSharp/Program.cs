using Lab3CSharp.SecTask;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your choise = ");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1: first(); break;
                case 2: second(); break;
            }
        }

        static void second()
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Enter the number of products:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter information about product {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Select the type of product (1 - toy, 2 - food product, 3 - dairy product):");
                int type = int.Parse(Console.ReadLine());

                Product product;
                switch (type)
                {
                    case 1:
                        Console.Write("Category: ");
                        string category = Console.ReadLine();
                        product = new Toy(name, price, category);
                        break;
                    case 2:
                        Console.Write("Shelf Life: ");
                        int endDate = int.Parse(Console.ReadLine());
                        product = new FoodProduct(name, price, endDate);
                        break;
                    case 3:
                        Console.Write("Origin: ");
                        string origin = Console.ReadLine();
                        Console.Write("Shelf Life: ");
                        int endDate2 = int.Parse(Console.ReadLine());
                        product = new DairyProduct(name, price, endDate2, origin);
                        break;
                    default:
                        Console.WriteLine("Incorrect type of product selected.");
                        return;
                }

                products.Add(product);
            }
            Console.WriteLine();
            products.Sort((x, y) => x.Price.CompareTo(y.Price));

            // Output the sorted array
            Console.WriteLine("Products sorted by price:");
            foreach (Product product in products)
            {
                product.Show();
                Console.WriteLine();
            }
        }

        static void first()
        {
            Console.WriteLine("Enter the triangle: ");
            Console.Write("Side A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Side B = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Side C = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Color = ");
            string color = Console.ReadLine();
            Console.WriteLine();
            ATriangle triangle = new ATriangle(a, b, c, color);

            triangle.PrintSides();
            Console.WriteLine($"P = : {triangle.Perimeter()}");
            Console.WriteLine($"S = : {triangle.Plosha()}");
            Console.WriteLine($"Or isosceles triangle: {triangle.IsIsoscles()}");
            Console.WriteLine($"Color: {triangle.Color}");
            Console.WriteLine();
            Console.WriteLine("You want to change sides or check color?");
            Console.WriteLine("Yes (y)");
            Console.WriteLine("No (n)");
            Console.Write("Choise = ");
            string choise = Console.ReadLine();
            if (choise == "n")
            {
                return;
            }
            else if (choise == "y")
            {
                Console.WriteLine("What side do you want to change? If you want to check color, enter <check>");
                string secChoise = Console.ReadLine();
                if (secChoise == "a" || secChoise == "A")
                {
                    Console.Write("Enter new value of A = ");
                    int newA = int.Parse(Console.ReadLine());
                    ATriangle triangleNewA = new ATriangle(newA, b, c, color);
                    Console.WriteLine("Triangle with new A: ");
                    triangle.PrintSides();
                    Console.WriteLine($"P = : {triangleNewA.Perimeter()}");
                    Console.WriteLine($"S = : {triangleNewA.Plosha()}");
                    Console.WriteLine($"Or isosceles triangle: {triangle.IsIsoscles()}");
                    Console.WriteLine($"Color: {triangleNewA.Color}");
                    Console.WriteLine();
                }
                else if (secChoise == "b" || secChoise == "B")
                {
                    Console.Write("Enter new value of B = ");
                    int newB = int.Parse(Console.ReadLine());
                    ATriangle triangleNewB = new ATriangle(a, newB, c, color);
                    Console.WriteLine("Triangle with new B: ");
                    triangle.PrintSides();
                    Console.WriteLine($"P = : {triangleNewB.Perimeter()}");
                    Console.WriteLine($"S = : {triangleNewB.Plosha()}");
                    Console.WriteLine($"Or isosceles triangle: {triangleNewB.IsIsoscles()}");
                    Console.WriteLine($"Color: {triangleNewB.Color}");
                    Console.WriteLine();
                }
                else if (secChoise == "check" || secChoise == "c" || secChoise == "C")
                {
                    Console.WriteLine($"Color: {triangle.Color}");
                }
            }
            else { Console.WriteLine("Wrong answer"); }
        }
    }
}
