using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = 25;

            Console.CursorVisible = false;

            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("(0)");
                Console.ResetColor();
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.W: case ConsoleKey.UpArrow: y--; break;
                    case ConsoleKey.S: case ConsoleKey.DownArrow: y++; break;
                    case ConsoleKey.A: case ConsoleKey.LeftArrow: x--; break;
                    case ConsoleKey.D: case ConsoleKey.RightArrow: x++; break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}