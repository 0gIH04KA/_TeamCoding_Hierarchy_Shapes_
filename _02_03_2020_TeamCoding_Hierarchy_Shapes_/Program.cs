using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_2020_TeamCoding_Hierarchy_Shapes_
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            ConsoleColor old = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(point1.PosX, point1.PosY);
            Console.WriteLine("*");
            Console.ForegroundColor = old;

            Point point2 = new Point(3, 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(point2.PosX, point2.PosY);
            Console.WriteLine("*");
            Console.ForegroundColor = old;

        }
    }
}
