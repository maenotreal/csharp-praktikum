using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.second_praktikum
{
    class fthree
    {
        private static void advert() => Console.WriteLine("3 ЗАДАНИЕ");
        private static void arr_draw(int[,] array, int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }
        }
        private static int[,] arr_fill(int[,] array, int a, int b)
        {
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    array[i, j] = rnd.Next(10, 99);
            return array;
        }
        private static int[,] second(int[,] array, int a, int b) 
        {
            int temp = 0;
            for (int i = 0; i < a; i++)
            {
                temp = array[i, 0];
                array[i, 0] = array[i, b / 2];
                array[i, b / 2] = temp;
            }
            return array; 
        }
        private static int[,] first(int[,] array, int a, int b) 
        {
            int temp = 0;
            for (int i = 0; i < a; i++)
            {
                        temp = array[i, (b/2) - 1];
                        array[i, (b / 2) - 1] = array[i, b / 2];
                        array[i, b / 2] = temp;
            }
            return array; 
        }
        public static int main()
        {
            Console.Clear(); advert();
            Console.WriteLine(); Console.WriteLine("Сколько строк вы хотите видеть в массиве?"); int a = int.Parse(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine("Сколько столбцов вы хотите видеть в массиве?"); int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            array = arr_fill(array, a, b);
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            arr_draw(array, a, b);
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            if (b % 2 == 0)
                array = first(array, a, b);
            else if (b % 2 != 0)
                array = second(array, a, b);
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            arr_draw(array, a, b);
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            Console.ReadKey();
            return 0;
        }
    }
}
