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
            
            Console.WriteLine("введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (F( n))
                Console.WriteLine("число картко 4 и не оканчивается на 0");
            else Console.WriteLine("либо число не кратно 4 " + "либо число оканчивается на 0");
        }
        static bool F(int n) =>
            (n % 4 == 0) && (n % 10 != 0);
    }
}
