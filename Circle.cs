using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS1;

namespace NS
{
    class Circle : AbstractFigure, IPrintable
    {
        private readonly string Name = "Окружность";
        public double R { get; private set; } // радиус окружности
        public Circle()
        {
           R = 0;
        }
        public Circle(double R)
        {
            this.R = R;            
        }
        public override double Perimeter()
        {
            return 2*Math.PI*R;
        }
        public override double Square()
        {
            return Math.PI * R * R;
        }       
        public string Print()
        {
            return $"{Name}:\n радиуса {R}\nПериметр:" +
                $"{Perimeter()}\nПлощадь: {Square()}\n";
        }      

    }
}
