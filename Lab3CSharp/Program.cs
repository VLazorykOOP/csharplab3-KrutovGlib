using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
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

            ATriangle triangle = new ATriangle(a, b, c, color);

            triangle.PrintSides();
            Console.WriteLine($"P = : {triangle.Perimeter()}");
            Console.WriteLine($"S = : {triangle.Plosha()}");
            Console.WriteLine($"Or isosceles triangle: {triangle.IsIsoscles()}");
            Console.WriteLine($"Color: {triangle.Color}");

            Console.WriteLine("You want to change sides or check color?");
            Console.WriteLine("Yes (y)");
            Console.WriteLine("No (n)");
            Console.Write("Choise = ");
            string choise = Console.ReadLine();
            if(choise == "n")
            {
                return;
            }
            else if(choise == "y")
            {
                Console.WriteLine("What side do you want to change? If you want to check color, enter <check>");
                string secChoise = Console.ReadLine();
                if(secChoise == "a" || secChoise == "A") 
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
                }
                else if(secChoise == "b" || secChoise == "B")
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
                }
                else if(secChoise == "check" || secChoise == "c"|| secChoise == "C")
                {
                    Console.WriteLine($"Color: {triangle.Color}");
                }
            }
            else { Console.WriteLine("Wrong answer"); }
        }

    }
}
