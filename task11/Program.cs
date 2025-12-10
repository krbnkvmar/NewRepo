using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1) Console.Write(arr[i]);
                else Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        static void NegArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (-1) * arr[i];
            }
        }
        static void SquareArray(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] * arr[i];
            }
            sum = Math.Sqrt(sum);
            Console.WriteLine("Результат из задания 3: " + sum);
        }
        static void FactorArray(int[] arr)
        {
            int[] result = new int[arr.Length];//3 and 5

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) result[i] = 1;
                else if (Math.Abs(arr[i]) == 1) result[i] = 1;
                else
                {
                    int x = Math.Abs(arr[i]);//3
                    result[i] = 1;
                    while (x > 1)
                    {
                        result[i] *= x;
                        x--;
                    }
                }
            }
            Console.WriteLine("Массив из задания 4: ");
            PrintArray(result);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите положительное целое число n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите случайное целое число от -20 до 20: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив из задания 1:");
            PrintArray(arr);
            NegArray(arr);
            Console.WriteLine("Массив из задания 2:");
            PrintArray(arr);
            SquareArray(arr);
            FactorArray(arr);
        }
    }
}
