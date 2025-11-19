using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число n");
            double n;
            double.TryParse(Console.ReadLine(), out n);
            if (n <= 0 ) { Console.WriteLine("Ошибка ввода!"); return; }
            double sum = 0;
            double ex = 0;
            for (double i = 1; i <= n; i++)
            {
                double a;
                Console.WriteLine("Введите действительное число a");
                double.TryParse(Console.ReadLine(), out a);
                if (i == 1) { sum += a; ex = a; }
                else if (i == 2) { sum += a; ex = a; }
                else
                {
                    if (sum > a + ex) sum = a + ex;
                    ex = a;
                }
            }
            Console.WriteLine($"Наименьшая сумма из введеных: {sum}");
        }
    }
}
