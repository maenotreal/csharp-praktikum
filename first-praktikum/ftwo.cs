using System;

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
                        sum += i;
                if (sum == n)
                    Console.WriteLine("У числа {0} сумма делителей равна {1}", a, n);
                ++a;
            }
        }
        private static void search_max(int a, int b)
        {
            int max = 0, v = 0;
            while (a <= b)
            {
                int sum = 0;
                for (int i = 1; i <= a; i++)
                    if (a % i == 0)
                        sum += i;
                if (sum > max)
                {
                    max = sum;
                    v = a;
                }
                ++a;
            }
            Console.WriteLine("Число {0} имеет максимальную сумму делителей равную {1}", v, max);
        }
        private static int reverse_search(int a, int n)
        {
            int b = n - 1, c = 0, u = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    c += i;
            while (b >= a)
            {
                int sum = 0;
                for (int i = 1; i <= b; i++)
                    if (b % i == 0)
                        sum += i;
                if (sum == c)
                {
                    Console.WriteLine("У числа {0} сумма делителей равна {1}, также как у числа {2}", b, c, n);
                    return 0;
                }
                --b;
            }
            if (u == 0)
                Console.WriteLine("Не найдено чисел с схожей суммой делителей :(");
            return 0;
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
        public static void f3(int a, int b)
        {
            Console.WriteLine();
            search_max(a, b);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void f4(int a, int n)
        {
            Console.WriteLine();
            reverse_search(a, n);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
