using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.first_praktikum
{
    class ffive
    {
        private static void advert() => Console.WriteLine("5 ЗАДАНИЕ");
        public static void f1()
        {
            advert();
            Console.WriteLine();
            Console.Write("Введите n: "); int n = int.Parse(Console.ReadLine());
            rec_method(n);
            Console.ReadKey();
        }

        private static void rec_method(int n)
        {
            if (n == 0)
                Console.WriteLine(n);
            else
            {
                Console.Write(n + " ");
                rec_method(n - 1);
            }
        }
    }
}
