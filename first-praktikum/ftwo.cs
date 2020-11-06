using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace csharp_praktikum.first_praktikum
{
    class ftwo
    {
        public static void advert() => Console.WriteLine("2 ЗАДАНИЕ");
        private static void sum_write(int a, int b)
        {
            while (a <= b)
            {
                int sum = 0;
                for (int i = 1; i <= a; i++)
                    if (a % i == 0)
                        sum += i;
                Console.WriteLine("У числа {0} сумма делителей равна {1}", a, sum);
                ++a;
            }
        }
        private static void sum_write(int a, int b, int n)
        {
            while (a <= b)
            {
                int sum = 0;
                for (int i = 1; i <= a; i++)
                    if (a % i == 0)
                    {
                        sum += i;                        
                    }
                if (sum == n)
                    Console.WriteLine("Число {0} имеет сумму делителей равную {1}", a, n);
                ++a;
            }
        }
        public static void f1(int a, int b)
        {
            Console.WriteLine();
            sum_write(a, b);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void f2(int a, int b, int n)
        {
            Console.WriteLine();
            sum_write(a, b, n);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
