using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Михаил Лермонтов");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Бородино");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("— Скажи-ка, дядя, ведь не даром");
            Console.WriteLine("Москва, спаленная пожаром,");
            Console.WriteLine("Французу отдана?");
            Console.WriteLine("Ведь были ж схватки боевые,");
            Console.WriteLine("Да, говорят, еще какие!");
            Console.WriteLine("Недаром помнит вся Россия");
            Console.WriteLine("Про день Бородина!");

            Console.ResetColor();
        }
    }
}
