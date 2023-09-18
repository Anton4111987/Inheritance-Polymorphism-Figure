using NS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS1;

namespace NS
{
    class SquareFigure : AbstractFigure, IDrawable
    {
        private readonly string Name = "Квадрат";
        public double A { get; private set; } // сторона 
        
        public SquareFigure()
        {
            A  = 0;
        }
        public SquareFigure(double A)
        {
            this.A = A;          
        }
        public override double Perimeter()
        {
            return 4 * A ;
        }
        public override double Square()
        {
            return A * A;
        }
        public void Draw()
        {
            Console.WriteLine(Name+"итератор i разделил на 2 чтобы в консоли как квадрат вывод был");
            for (int i = 0; i < A/2; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}
