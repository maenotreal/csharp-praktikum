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
            int ind = -1;
            Random rnd = new Random();
            Console.Write("Сколько элементов вы хотите видеть в массиве? "); int n = int.Parse(Console.ReadLine()); List<int> array = new List<int>();
            for (int i = 0; i < n; i++)
                array.Add(rnd.Next(1, 42));
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0 && i != ind)
                {
                    ind = array.IndexOf(array[i]) + 1;
                    array.Insert(i, rnd.Next(1, 42));
                    ++n;
                }
            }
            Console.WriteLine("------------------------------");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
