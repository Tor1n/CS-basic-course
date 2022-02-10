using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите длинну последовательности: ");
            int sequence = int.Parse(Console.ReadLine());
            int[] row = new int[sequence];

            Console.WriteLine($"Введите {sequence} чисел");
            for (int i = 0; i < sequence; i++)
            {
                row[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in row)
            {
                Console.Write($"{item} ");
            }
            int max = row.Max();
            Console.Write($"Максимальное значение последовательности: {max}");
            Console.ReadKey();
        }
    }
}
