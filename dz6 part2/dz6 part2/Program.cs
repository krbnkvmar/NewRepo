using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyWord = "кратер";
            Console.WriteLine(MyWord.Remove(1,1));
            Console.WriteLine(MyWord.Remove(0, 5)+ MyWord.Remove(5, 1).Remove(0, 4) + MyWord.Remove(3, 3).Remove(1, 1));
        }
    }
}