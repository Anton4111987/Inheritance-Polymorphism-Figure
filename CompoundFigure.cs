using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS1;

namespace NS
{
    class CompoundFigure : AbstractFigure, IPrintable
    {
        private readonly string Name = "прямоугольник в кругу";

        Rectangle Rectangle { get; set; }
        Circle Circle { get; set; }

        public CompoundFigure(Rectangle Rectangle, Circle Circle)
        {
            this.Rectangle = Rectangle;
            this.Circle = Circle;
        }
        public CompoundFigure()
        {
            Rectangle = new Rectangle(1, 2);
            Circle = new Circle(3);
        }
        public override double Perimeter()
        {
            return Rectangle.Perimeter()+Circle.Perimeter();
        }
        public override double Square()
        {
            return Perimeter();
        }
       
        public string Print()
        {
            return $"{Name}:\n размер прямоугольника {Rectangle.A} на {Rectangle.B}\n" +
               $"Окружность радиуса {Circle.R}\nОбщий периметр этих фигур:" +
               $"{Perimeter()}\nОбщая площадь этих фигур: {Square()}\n";
        }
       
    }
}
