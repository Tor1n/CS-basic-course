using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod3_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы проверить является ли число простым, введите целое число:");
            int number = int.Parse(Console.ReadLine());

            bool condition = false;
            while (number > 0)
            {                
                    for (int k = 2; k < number -1; k++)
                    {
                        if (number % k == 0)
                        {
                           condition = true;
                           break;
                         }
                    Console.WriteLine($"k >>> {k}");
                    }
                
            }

            if (condition = true)
            {
                Console.WriteLine($"К сожалению число {number} не является простым");
            }
            else
            {
                Console.WriteLine("Ура! число простое");
            }
            Console.ReadKey();
        }
    }
}
