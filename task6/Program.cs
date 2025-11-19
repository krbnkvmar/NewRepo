using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            long sum = 0;
            Console.WriteLine("Введите натуральное число n");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= n; i++) {
                long num = 1;
                for (int j = 1; j <= i; j++) {
                    num*=i;
                }
                sum += num;
            }
            Console.WriteLine($"Результат программы равен { sum}");
        }
    }
}