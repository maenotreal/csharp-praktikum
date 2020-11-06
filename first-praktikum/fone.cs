using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace csharp_praktikum.first_praktikum
{
    class fone
    {
        private static void advert() => Console.WriteLine("1 ЗАДАНИЕ");
        public static void f1()
        {
            advert(); Console.WriteLine();
            Console.Write("Введите натуральное число: "); double n = double.Parse(Console.ReadLine());
            double a = 0, b = n;
            for (int i = 0; i < 3; i++)
            {
                a += (Math.Sqrt(n) + n) / 2;
                ++b;
                n += b;
            }
            Console.WriteLine("Ответ: " + a);
            Console.ReadKey();
        }
    }
}
