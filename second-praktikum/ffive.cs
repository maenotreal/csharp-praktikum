using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_praktikum.second_praktikum
{
    class ffive
    {
        public static void main()
        {
            Console.Clear();
            Random rnd = new Random();
            List<int> array = new List<int>();
            Console.WriteLine("Введите размер массива: "); int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
                array.Add(rnd.Next(1, 42));
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            foreach (int n in array)
                Console.Write($"{n} ");
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            for (int i = 0; i < c; i++)
            {
                if (array[i] % 2 == 0)
                    array.Insert(i, rnd.Next(1, 42));
            }
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            foreach (int n in array)
                Console.Write($"{n} ");
            Console.WriteLine(); Console.WriteLine("--------------------------------"); Console.WriteLine();
            Console.ReadKey();
        }
    }
}
