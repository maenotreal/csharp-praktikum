using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.second_praktikum
{
    class second_praktikum
    {
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
                    fone.main();
                    goto main;
                case 2:
                    ftwo.main();
                    goto main;
                case 3:
                    fthree.main();
                    goto main;
                case 4:
                    fone.main();
                    goto main;
                case 5:
                    fone.main();
                    goto main;
                case 6:
                    return 0;
            }
            return 0;
        }
    }
}
