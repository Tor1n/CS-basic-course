using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение: ");
            string userInput = Console.ReadLine();

            Console.WriteLine(ReversWords(userInput));



            Console.ReadKey();
        }
        static string[] Split(string text)
        {
            string[] words = text.Split(' ');
            return words;

        }
        
        static string ReversWords(string input)
        {
            string[] words;
            
            words = Split(input);

            Array.Reverse(words);
            string finalPhrase = "";

            for (int i = 0; i < words.Length; i++)
            {
               finalPhrase += words[i] + " ";
            }
            return finalPhrase;
        }
    }
}
