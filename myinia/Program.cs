using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myinia
{
    class Program
    {
        static void DrawingSqare(int x1, int y1, int x2, int y2)
        {
            Console.SetCursorPosition(x1, y1);
            for (int i = x1; i <= x2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            y1++;
            for (int j = y1; j <= y2; j++)
            {
                Console.SetCursorPosition(x1, j);

                for (int i = x1; i <= x2; i++)
                {

                    if ((i == x1) || (i == x2))
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.SetCursorPosition(x1,y2);
            for (int i = y1; i <= y2; i++)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {
            DrawingSqare(1, 1, 5, 5);
            Console.ReadKey();

    

        }

    }
}
