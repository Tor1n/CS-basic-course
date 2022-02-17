using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение: ");
            string userInput = Console.ReadLine();

            string[] words = Split(userInput);

            Console.WriteLine("\nПеречень слов из предложения: ");
            Print(words);
                        
            Console.ReadKey();
        }
        static string[] Split(string text)
        {
            string[] words = text.Split(' ');
            return words;

        }
        static void Print(string[] outputWords)
        {
            foreach (var item in outputWords)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
