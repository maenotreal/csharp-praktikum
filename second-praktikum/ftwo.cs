using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.second_praktikum
{
    class ftwo
    {
        private static void advert() => Console.WriteLine("2 ЗАДАНИЕ");
        public static int main()
        {
            Random rnd = new Random();
            Console.Clear(); advert();
            Console.WriteLine(); Console.Write("Введите кол-во чисел в последовательности: "); int n = int.Parse(Console.ReadLine());
            int[] array = new int[n]; int max = 0;
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);
            Console.WriteLine();
            foreach (int numbers in array)
            {
                if (max < numbers)
                    max = numbers;
                Console.Write($"{numbers} ");
            }
            Console.WriteLine(); Console.WriteLine($"Максимальное число в последовательности из {n} чисел, равно: {max}");
            Console.ReadKey();
            return 0;
        }
    }
}
