using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.first_praktikum
{
    class fthree
    {
        private int a = -10;
        private int b = 10;
        private double h = 0.5;
        private static void advert() => Console.WriteLine("3 ЗАДАНИЕ");
        private static void func(double x)
        {
            fthree per = new fthree();
            double y = 0;
            while (x <= per.b)
            {
                if (Math.Abs(x) <= 1)
                    y = Math.Pow(x, 2) - 1;
                else if (1 < Math.Abs(x) && Math.Abs(x) <= 2)
                    y = (2 * x) - 1;
                else if (Math.Abs(x) > 2)
                    y = Math.Pow(x, 5) - 1;
                Console.WriteLine("y = " + y);
                x += per.h;
            }
        }

        public static void f1()
        {
            fthree per = new fthree();
            err2:
            advert();
            Console.WriteLine();
            Console.Write("Введите x: "); double x = int.Parse(Console.ReadLine());
            if (x < per.a || x > per.b)
            {
                Console.WriteLine("Переменная x выходит за пределы отрезка!");
                goto err2;
            }
            Console.WriteLine();
            func(x);
            Console.ReadKey();
        }
    }
}
