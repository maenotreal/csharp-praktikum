using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.first_praktikum
{
    class fsix
    {
        static int a = 1, b = 1;
        private static void advert() => Console.WriteLine("6 ЗАДАНИИЕ");
        public static void f1()
        {
            advert(); Console.WriteLine();
            Console.Write("Введите n: "); int n = int.Parse(Console.ReadLine());
            rec_method(n);
            Console.Read();
        }
        public static void rec_method(int n)
        {
            for (int i = 1; i < n; i++)
            {
                Console.Write(a);
                for (int j = n - i; j > 1; j--)
                {
                    Console.Write(" + 1");
                }
                Console.Write(" + " + b);
                Console.WriteLine();
                b++;
            }
            b = a + 1;
            a++;
            if (n > 1)
                rec_method(n - 2);
        }
    }
}
