using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace csharp_praktikum.first_praktikum
{
    class ftwo
    {
        private int a;
        private int b;
        private static void array_out()
        {
        }
        private static void advert() => Console.WriteLine("2 ЗАДАНИЕ");
        private static void rewrite(int a1, int b1)
        {
            ftwo rew = new ftwo();
            rew.a = a1; rew.b = b1;
        }
        private static void sum_write()
        {

        }
        public static void f1(int a, int b)
        {
            rewrite(a, b); 
            while (a <= b)
            {
                int sum = 0;
                for (int i = 1; i <= a; i++)
                    if (a % i == 0)
                        sum += i;
                Console.WriteLine("У числа {0} сумма делителей равна {1}", a, sum);
                ++a;
            }
            Console.ReadKey();
        }
    }
}
