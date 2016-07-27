using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(8, 2, '*');
            p1.Draw();

            Point p2 = new Point(7, 10, '?');
            p2.Draw();

            Point p3 = new Point(3, 15, '%');
            p3.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);

            int x = numList[ 0 ];
            int y = numList[ 1 ];
            int z = numList[ 2 ];
            int u = numList[3];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            Console.ReadLine();
     

        }
    }
}
