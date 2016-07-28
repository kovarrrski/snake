using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new snake.Point(x, y, sym);
                pList.Add(p);
            }
        }
        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Drow();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
