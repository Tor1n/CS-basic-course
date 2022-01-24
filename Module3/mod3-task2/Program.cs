using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!\nУточните кол-во карт у вас на руках:");
            int cards = int.Parse(Console.ReadLine());
            Console.WriteLine("Хорошо, у вас на руках {0} карт.", cards);

            int summ = 0;
            for (int i = 0; i < cards; i++)
            {
                Console.WriteLine("Введите номинал карты:");
                string card = Console.ReadLine();

                switch (card)
                {
                    case "2":
                        summ = summ + 2;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    case "3":
                        summ = summ + 3;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    case "4":
                        summ = summ + 4;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    case "5":
                        summ = summ + 5;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    case "6":
                        summ = summ + 6;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    case "7":
                        summ = summ + 7;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    case "8":
                        summ = summ + 8;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    case "9":
                        summ = summ + 9;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        summ = summ + 10;
                        Console.WriteLine($"Текущая сумма очков: {summ}");
                        break;
                    
                    default:
                        Console.WriteLine($"Принимаются цифры от 2 до 10, либо J,Q,K,Q\nТекущая сумма очков: {summ}");
                        break;
                }
            }
            Console.WriteLine("Суммарное кол-во очков: {0}", summ);
            Console.ReadKey();
        }
    }
}
