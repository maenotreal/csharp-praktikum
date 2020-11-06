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
            fone.f1();
            Console.WriteLine("---------------------------------");
            Console.Write("Введите a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: "); int b = int.Parse(Console.ReadLine());
            ftwo.f1(a, b);
        }
    }
}
