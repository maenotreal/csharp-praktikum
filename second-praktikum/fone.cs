using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.second_praktikum
{
    class fone
    {
        private static void advert() => Console.WriteLine("1 ЗАДАНИЕ");
        private static int[] array_zap(params int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 255);
            return array;
        }
        private static void array_method_1()
        {
            Console.WriteLine(); Console.WriteLine("Сколько элементов вы хотите видеть в массиве?"); int n = int.Parse(Console.ReadLine());
            int[] array = new int[n]; int c = 0;
            array = array_zap(array);
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            foreach (int number in array)
                Console.Write(number + " ");
            foreach (int number in array)
                if (number % 2 != 0) ++c;
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine($"В данном массиве {c} нечетных элементов");
            Console.ReadKey();
        }
        private static int[,] array_zap(int[,] array, int a, int b)
        {
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++) 
                    array[i , j] = rnd.Next(1, 99);
            return array;
        }
        private static void array_method_2()
        {
            Console.WriteLine(); Console.WriteLine("Сколько строк вы хотите видеть в массиве?"); int a = int.Parse(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine("Сколько столбцов вы хотите видеть в массиве?"); int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b]; int c = 0;
            array = array_zap(array, a, b);
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                    Console.Write($"{array[i, j]} "); 
                Console.WriteLine();
            }
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    if (array[i, j] % 2 != 0)
                        ++c;
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine($"В данном массиве {c} нечетных элементов");
            Console.ReadKey();
        }
        public static int main()
        {
            main:
            Console.Clear();
            advert(); Console.WriteLine();
            Console.WriteLine("Вы хотите использовать одномерный(1) массив или двумерный(2)? Чтобы выйти из задания введите 3."); int check = int.Parse(Console.ReadLine());
            switch(check)
            {
                case (1):
                    array_method_1();
                    goto main;
                case (2):
                    array_method_2();
                    goto main;
                case (3):
                    return 0;
            }
            return 0;
        }
    }
}
