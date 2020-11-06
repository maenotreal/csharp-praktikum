using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.first_praktikum
{
    class first_praktikum
    {
        private static void advert() => Console.WriteLine("1 ПРАКТИКУМ");
        public static void firstmain()
        {
            Console.Clear();
            advert(); Console.WriteLine("---------------------------------");
            Console.Write("Введите натуральное число: "); double n = double.Parse(Console.ReadLine());
            fone.f1(n);
        }
    }
}
