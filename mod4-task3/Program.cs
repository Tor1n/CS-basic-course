using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное число диапазона: ");
            int maxvalue = int.Parse(Console.ReadLine());
            Random r = new Random();
            int secretnum = r.Next(maxvalue + 1);
            
            Console.WriteLine($"Теперь отгадайте случайное число от 0 до {maxvalue}");
            int variant;
            string userinput;
            while (true)
            {
                userinput = Console.ReadLine();
                if (userinput == "")
                {
                    break;
                }
                else
                {
                    variant = Convert.ToInt32(userinput);
                }
                    
                if (variant > secretnum)

                {
                    Console.WriteLine("Нет, загаданное число меньше");                    
                }

                else if (variant < secretnum)
                {
                    Console.WriteLine("Нет, загаданное число больше");                    
                }
                else
                {
                    Console.WriteLine("Ура!");
                    break;
                }

            }
            Console.Write($"Загаданное число: {secretnum}");
            Console.ReadKey();
        }
    }
}
