

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            Console.WriteLine("Shooter:");
            Console.Write("\r\n\tw - вперед\r\n\ts - назад\r\n\ta - влево\r\n\td - вправо\r\n\tSpace - прыжок\r\n\tEnter - огонь\r\n\tEsc - выйти");
            Console.CursorLeft = 0; Console.CursorTop = 9;

            ConsoleKey key;
            do
            {
                //char key = Console.ReadKey().KeyChar;
                key = Console.ReadKey(true).Key;
                switch (key) {
                    //case 'w': Console.WriteLine(" вперед"); break;
                    //case 's': Console.WriteLine(" назад"); break;
                    //case 'a': Console.WriteLine(" влево"); break;
                    //case 'd': Console.WriteLine(" вправо"); break;
                    //case (char)13: Console.WriteLine(" enter - огонь"); break;
                    //case ' ': Console.WriteLine("space - прыжок"); break;

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W: Console.WriteLine(" вперед"); break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S: Console.WriteLine(" назад"); break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A: Console.WriteLine(" влево"); break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D: Console.WriteLine(" вправо"); break;
                    case ConsoleKey.Enter: Console.WriteLine(" enter - огонь"); break;
                    case ConsoleKey.Spacebar: Console.WriteLine("space - прыжок"); break;


                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            } while (Flag);
        }
    }
}
