using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, count = 0;
            Console.WriteLine("Введите натуральное число x");
            int.TryParse(Console.ReadLine(), out x);
            string binary = "";
            int num = x;
            for (; num > 0;)
            {
                int ost = num % 2;
                count += ost;
                binary = ost + binary;
                num = num / 2;
            }
            Console.WriteLine($"Количество единиц в двоичной записи числа: {count}");
        }
    }
}
