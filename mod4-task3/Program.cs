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
            string variant = (Console.ReadLine());
            int userinput = int.Parse($"{variant}");
            while (true)
            {

                if (variant == " ")
                {
                    break;
                }
                else if (userinput > secretnum)

                {
                    Console.WriteLine("Нет, загаданное число меньше");
                    userinput = int.Parse(Console.ReadLine());
                }

                else if (userinput < secretnum)
                {
                    Console.WriteLine("Нет, загаданное число больше");
                    userinput = int.Parse(Console.ReadLine());
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
