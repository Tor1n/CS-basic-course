using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите цисло, чтобы определить простое ли оно: ");
            int number = int.Parse(Console.ReadLine());
            int k = 2;
            bool condition = false;
            while (k < number)
            {
                
                
                    
                    if (number % k == 0)
                    {
                        condition = true;
                        break;

                }
                else
                {
                    k++;
                    Console.WriteLine($"k сейчас:{k}");
                }
                
            }
            if (condition == false)
            {
                Console.WriteLine("Число не является простым");
            }
            else
            {
                Console.WriteLine("Число простое");
            }
            Console.ReadKey();
        }
    }
}
