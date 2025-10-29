using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента");

            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x:F2}) = {F(x):F2}");
        }
        static double F(double x)
        {
            if (Math.Sin(x) > 0) return Math.Cos(x);
            else if (Math.Sin(x) == 0) return x / Math.PI;
            else return (-Math.Cos(x));
        }
    }
}
