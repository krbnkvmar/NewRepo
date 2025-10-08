using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = F(3,2)+F(5,3)+F(7,4);

            Console.WriteLine("x = " + Math.Round(x,3));
        }
        static double F(double a, double b) => Math.Log(a + Math.Pow(b, a)) / Math.Log(b + Math.Pow(a, b));
    }
}
