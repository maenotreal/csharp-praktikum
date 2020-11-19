using System;


namespace csharp_praktikum.first_praktikum
{
    class first_praktikum
    {
        private static void advert() => Console.WriteLine("1 ПРАКТИКУМ");
        public static int main()
        {
            main:
            Console.Clear();
            for (int i = 1; i <= 6; i++)
            {
                if (i < 6)
                    Console.WriteLine(i + " задание");
                else
                    Console.WriteLine(i + " выход из " + i + " практикума");
            }
            Console.WriteLine("--------------------------------------");
            Console.Write("Введите номер практикума: "); int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    firstmain();
                    goto main;
                case 2:
                    secondmain();
                    goto main;
                case 3:
                    thirdmain();
                    goto main;
                case 4:
                    fourthmain();
                    goto main;
                case 5:
                    fivemain();
                    goto main;
                case 6:
                    return 0;
            }
            return 0;
        }
        private static void firstmain()
        {
            Console.Clear();
            advert(); Console.WriteLine("---------------------------------");
            fone.f1();
        }
        private static void secondmain()
        {
            Console.Clear();
            advert(); Console.WriteLine("---------------------------------");
            ftwo.advert();
            Console.WriteLine();
            Console.Write("Введите a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: "); int b = int.Parse(Console.ReadLine());
            ftwo.f1(a, b);
            Console.Write("Введите сумму делителей которую вы хотите увидеть: "); int n = int.Parse(Console.ReadLine());
            ftwo.f2(a, b, n);
            ftwo.f3(a, b);
            Console.Write("Введите число A: "); n = int.Parse(Console.ReadLine());
            ftwo.f4(a, n);
        }
        private static void thirdmain()
        {
            Console.Clear();
            advert(); Console.WriteLine("---------------------------------");
            fthree.f1();
        }
        private static void fourthmain()
        {
            Console.Clear();
            advert(); Console.WriteLine("---------------------------------");
            ffour.f1();
        }
        private static void fivemain()
        {
            Console.Clear();
            advert(); Console.WriteLine("---------------------------------");
            ffive.f1();
        }
    }
}
