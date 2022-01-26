using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите цисло, чтобы определить чётность: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("0 не может быть преобразован");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Вы ввели чётное число");
            }
            else
            {
                Console.WriteLine("Вы ввели нечётное число");
            }
            Console.ReadKey();
        }
    }
}
