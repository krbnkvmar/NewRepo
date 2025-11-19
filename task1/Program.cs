using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число a");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральное число b больше введеного числа а");
            var b = int.Parse(Console.ReadLine());
            long sum = 0;
            if (b > a)
                {
                for (int i = 0; i <= b-a; i++)
                    {
                        sum += (long)(a+i) *(a+ i);
                    }
                 Console.WriteLine($"Сумма квадратов целых чисел от a до b: {sum}");
                }
             else
                Console.WriteLine("Введите правильные значения");
        }
    }
}
