using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS1;

namespace NS
{
    class Rectangle : AbstractFigure, IDrawable
    {
        private readonly string Name = "Прямоугольник";
        public double A { get; private set; } // сторона А
        public double B { get; private set; } // сторона B
        public Rectangle()
        {
            A = B = 0;
        }
        public Rectangle(double A, double B)
        {
            this.A = A;
            this.B = B;
        }
        public override double Perimeter()
        {
            return 2 * (A+B);
        }
        public override double Square()
        {
            return A*B;
        }
            
        public void Draw()
        {
            Console.WriteLine(Name);
            for (int i = 0; i < A; i++)
            {
                for(int j = 0; j < B; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
