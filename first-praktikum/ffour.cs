using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.first_praktikum
{
    class ffour
    {
        private static void advert() => Console.WriteLine("4 ЗАДАНИЕ");
        private static double cool_pow(double n, double a)
        {
            double awnser = n;
            for (int i = 1; i < a; i++)
                awnser *= n;
            return awnser;
        }
        //private static double a1(double a, double n) => n == 1 ? 1 : a * (n / 2) + 1;
        /*private static double F(double n) 
        {
            if (Math.Pow(2, ))
            if (n == 1)
                return 1;
            else
                return F(n / 2) + 1;
        }*/
        public static void f1() 
        {
            advert();
            Console.WriteLine();
            //Console.Write("Введите n: "); double x = int.Parse(Console.ReadLine());
            Console.WriteLine(5);
        }
    }
}
