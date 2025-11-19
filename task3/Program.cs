using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ex = 1;
            double num;
            string input;

            while (true) {
                Console.WriteLine("Введите действительное число а (или 0 для завершения программы)");
                input = Console.ReadLine();
                double.TryParse( input, out num );

                if ( num == 0 ) break;
                Console.WriteLine($"Произведение:{num * ex}");
                ex = num*ex;
            }
        }
    }
}
