using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class ATriangle
    {
        private int katetA;
        private int katetB;
        private readonly int gipotenuzaC;
        private readonly string color;

        public ATriangle(int katetA, int katetB, int gipotenuzaC,string color )
        {
            this.katetA = katetA;
            this.katetB = katetB;
            this.gipotenuzaC = gipotenuzaC;
            this.color = color;
            
        }

        public void PrintSides()
        {
            Console.WriteLine($"Sides of triange = \n a = {katetA},\n b = {katetB},\n Gipotenuza = {gipotenuzaC}");
        }

        public int Perimeter()
        {
            return katetA + katetB + gipotenuzaC;
        }

        public double Plosha()
        {
            double p = Perimeter() / 2.0;
            return Math.Sqrt(p * (p - katetA) * (p - katetB) * (p - gipotenuzaC));
        }

        public bool IsIsoscles()
        {
            return katetA == katetB || katetB == gipotenuzaC || gipotenuzaC == katetA;
        }

        public int SideA
        {
            get { return katetA; }
            set { katetA = value; }
        }
        public int SideB
        {
            get { return katetB; }
            set { katetB = value; }
        }
        public int SideC
        {
            get { return gipotenuzaC; }
        }

        public string Color
        {
            get { return color; }
        }


    }
}
