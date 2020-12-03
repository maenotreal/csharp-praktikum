using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.second_praktikum
{
    class ffour
    {
        private static void advert() => Console.WriteLine("4 ЗАДАНИЕ");
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
            int[,] array = new int[a, b]; int[,] array_dup = new int[b, 2];
            array = arr_fill(array, a, b);
            for (int i = 0; i < b; i++)
                array_dup[i, 0] = i + 1;
            for (int j = 0; j < b; j++)
            {
                int sum = 0;
                for (int i = 0; i < a; i++)
                {
                    if (array[i, j] >= 0 && array[i, j] % 2 == 0)
                        sum += array[i, j];
                }
                array_dup[j, 1] = sum;
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
