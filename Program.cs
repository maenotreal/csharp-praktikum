using csharp_praktikum.first_praktikum;
using System;

namespace csharp_praktikum
{
    class Program
    {
         static void Main(string[] args)
        {
            main:
            Console.Clear();
            for (int i = 1; i <= 4; i++)
            {
                if (i < 4)
                    Console.WriteLine(i + " практикум");
                else
                    Console.WriteLine(i + " выход из программы");
            }
            Console.WriteLine("--------------------------------------");
            Console.Write("Введите номер практикума: "); int choose = int.Parse(Console.ReadLine());
            switch (choose) 
            {
                case 1:
                    first_praktikum.first_praktikum.main();
                    goto main;
                case 2:
                    second_praktikum.second_praktikum.main();
                    goto main;
                case 3:
                   first_praktikum.first_praktikum.main();
                    goto main;
                case 4:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
