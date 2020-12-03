using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.second_praktikum
{
    class fsix
    {
        private static void advert() => Console.WriteLine("6 ЗАДАНИЕ");
        private static void arr_draw(int[,] array, int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (array[i, j] >= 0)
                        Console.Write($" {array[i, j]} ");
                    else
                        Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        private static int[,] arr_fill(int[,] array, int a, int b)
        {
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    array[i, j] = rnd.Next(-9, 9);
            return array;
        }
        public static void main()
        {
            Console.Clear(); advert();
            Console.WriteLine(); Console.WriteLine("Сколько строк вы хотите видеть в массиве?"); int a = int.Parse(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine("Сколько столбцов вы хотите видеть в массиве?"); int b = int.Parse(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine("Введите число: "); int check_sum = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b]; int[,] array_dup = new int[1, b];
            array = arr_fill(array, a, b);
            int k = 0;
            for (int i = 0; i < a; i++)
            {
                int sum = 0;
                for (int j = 0; j < b; j++)
                {
                    sum += array[i, j];

                }
                if (sum < check_sum)
                {
                    for (int u = 0; u < a)
                }
            }
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            arr_draw(array, a, b);
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            arr_draw(array_dup, b, 2);
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            Console.ReadKey();
        }
    }
}
