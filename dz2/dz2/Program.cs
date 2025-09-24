using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону треугольника");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите первый прилежащий угол в градусах");
            var ugolvgrad1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второй прилежащий угол в градусах");
            var ugolvgrad2 = double.Parse(Console.ReadLine());

            var area = Math.Abs(a * a ) * (Math.Sin(ugolvgrad1 * Math.PI / 180)* Math.Sin(ugolvgrad2 * Math.PI / 180)/ (2*Math.Sin((ugolvgrad1+ ugolvgrad2) * Math.PI / 180)));

            var perimetr = Math.Abs(a) + Math.Sin(ugolvgrad1 * Math.PI / 180) * Math.Abs(a) / Math.Sin((180 - ugolvgrad1 - ugolvgrad2) * Math.PI / 180) + Math.Sin(ugolvgrad2 * Math.PI / 180) * Math.Abs(a) / Math.Sin((180 - ugolvgrad1 - ugolvgrad2) * Math.PI / 180);

            Console.WriteLine("Площадь равна " + area);

            Console.WriteLine("Периметр равен " + perimetr);
        }
    }
}
