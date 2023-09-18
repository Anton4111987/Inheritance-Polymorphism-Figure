using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
           
           FigureScene figurescene = new FigureScene
                                    ( new AbstractFigure[] 
                                     { 
                                          new Circle(10),
                                          new Rectangle(5,7),
                                         new Trapezoid(42, 8, 17, 17, 17),
                                          new CompoundFigure(new Rectangle(5,8), new Circle(20)),
                                          new SquareFigure(20)
                                     });
            figurescene.Show();
        
        }
    }
}
