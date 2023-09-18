using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS1;

namespace NS
{
    class Trapezoid : AbstractFigure, IDrawable
    {
        private readonly string Name = "Трапеция";
        double A { get; set; } // сторона основания А
        double B { get; set; } // сторона основания В
        double C { get; set; } // сторона основания C
        double D { get; set; } // сторона основания D
        double H { get; set; } // высота трапеции

        public Trapezoid()
        {
            A = B = C = D = H = 0;
        }
        public Trapezoid(double A, double B, double C, double D, double H)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.H = H;
        }
        public override double Perimeter()
        {
            return A + B + C + D;
        }
        public override double Square()
        {
            return (A + B) / 2 * H;
        }      
        public void Draw()
        {
            Console.WriteLine(Name);
            for (int i = 0; i < H; i++)
            {               
                for (int j = 0; j < A; j++)
                {
                    if ((j >= (A - B) / 2 && j < A - ((A - B) / 2) && i==0) ||
                        (j > 0 && j < A - 1 && i == H - 1) ||
                        i + j >= H - 1 && j - i <= A - H)                           
                        Console.Write("*");                 
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
