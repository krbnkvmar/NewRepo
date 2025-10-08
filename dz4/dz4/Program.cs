using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число");

            var x=double.Parse(Console.ReadLine());
            var y = F(x);

            Console.WriteLine("y = " + y);
        }
        static double F(double x) => Math.Abs((1 + Math.Sqrt(x + 1) / (1 - Math.Sqrt(x - 1))));
            }
}