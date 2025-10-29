using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (F( n))
                Console.WriteLine("Число кратно 4 и не оканчивается 0");
            else Console.WriteLine("Либо число не кратно 4, " + "либо число оканчивается на 0");
        }
        static bool F(int n) =>
            (n % 4 == 0) && (n % 10 != 0);
    }
}
