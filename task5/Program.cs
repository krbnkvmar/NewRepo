using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("enter m");
            int.TryParse(Console.ReadLine(), out m);
            Console.WriteLine("enter n");
            int.TryParse((string)Console.ReadLine(), out n);
            int a = m, b = n;
            while (b != 0)
            {
                int del = b;
                b = a % b;
                a = del;
            }
            int commondel = a;
            int p=m/commondel, q=n/commondel;
            Console.WriteLine($"Сокращенная дробь: {p}/{q}");
        }
    }
}
