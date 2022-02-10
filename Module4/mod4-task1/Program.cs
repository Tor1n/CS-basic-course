using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите цисло строк в матрице: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Укажите цисло столбцов в матрице: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            Random r = new Random();
            int summ = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                    summ = summ + matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.Write($"Сумма всех элементов матрицы: {summ}");
            Console.ReadKey(); 
        }
    }
}
