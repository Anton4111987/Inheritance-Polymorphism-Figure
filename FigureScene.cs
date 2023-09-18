using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS1;

namespace NS
{
    class FigureScene
    {
        public AbstractFigure[] Figure { get; set; } // массив фигур, поле класса
       
        public FigureScene(AbstractFigure[] Figure) // конструктор с параметрами
        {
            this.Figure = Figure;
        }

        public void Show() // реализация метода вывода
        {
            foreach (AbstractFigure figure in this.Figure)
            {              
                if (figure is IPrintable)
                {
                    IPrintable printable = (IPrintable)figure;
                    Console.WriteLine("Печать фигуры (Ptint)");
                    Console.WriteLine(printable.Print());
                }
                else if(figure is IDrawable)
                {
                    IDrawable drawable = (IDrawable)figure;
                    Console.WriteLine("Отрисовка фигуры (Draw)");
                    drawable.Draw();
                }
                else
                    Console.WriteLine("Не удалось привести тип объекта");
            }
        }
      
    }
}
