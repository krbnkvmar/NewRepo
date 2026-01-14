using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    internal class Program
    {
        static bool Cube(long n)
        {
            if (n < 0) return false;
            long koren = (long)Math.Round(Math.Pow(n, 1.0 / 3));
            return koren * koren * koren == n;
        }
        static bool SwapNum(long a, long b)
        {
            int[] arrA = new int[10];
            int[] arrB = new int[10];
            while (a > 0)
            {
                int number = (int)(a % 10);
                arrA[number]++;
                a /= 10;
            }
            while (b > 0)
            {
                int number = (int)(b % 10);
                arrB[number]++;
                b /= 10;
            }
            for (int i = 0;i<10;i++)
            {
                if (arrA[i] != arrB[i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            for (long i = 1; i < 5000; i++)
            {
                long cube1 = i * i * i;
                int count = 0;
                for (long j = 1; j < 5000; j++)
                {
                    long cube2 = j * j * j;
                    string s1=cube1.ToString();
                    string s2=cube2.ToString();
                    if (s2.Length > s1.Length) { break; }
                    if (s1.Length == s2.Length)
                    {
                        if (SwapNum(cube1, cube2)) count++;
                    }
                }
                if (count == 3)
                {
                    if (Cube(cube1))
                    {
                        Console.WriteLine($"Число {cube1} является кубом числа {i} и является наименьшим кубом, перестановки цифр которого дают ровно три куба");
                        break;
                    }
                }
            }
        }
    }
}