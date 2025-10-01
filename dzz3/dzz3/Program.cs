using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите одну сторону прямоугольника");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата");
            var k = int.Parse(Console.ReadLine());

            var vmest_m = m / k;
            var vmest_n = n / k;
            var result = vmest_m * vmest_n;

            Console.WriteLine("От прямоугольника можно отрезать " + result + " целых квадратов");
        }
    }
}
