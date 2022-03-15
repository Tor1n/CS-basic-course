using System;
using System.Text;
using System.IO;

namespace module6
{
    internal class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Для просмотра данных нажмите 1, для добавления нажмите 2");
            int initKey = int.Parse(Console.ReadLine());
            InitOption(initKey);            
        }
        static void WriteData()
        {
            using (StreamWriter SWriter = new StreamWriter(@"f:\Igor\Сотрудники.txt", true, Encoding.UTF8))
            {
                char k = 'д';
                do
                {               
                string note = string.Empty;
                Console.Write("\nВведите ID:");
                note += $"{Console.ReadLine()}";

                string now = DateTime.Now.ToString();
                note += $"#{now}";

                Console.WriteLine("ФИО: ");
                note += $"#{Console.ReadLine()}";

                Console.WriteLine("Возраст: ");
                note += $"#{Console.ReadLine()}";

                Console.WriteLine("Рост: ");
                note += $"#{Console.ReadLine()}";

                Console.WriteLine("Дата рождения DD.MM.YYYY: ");
                note += $"#{Console.ReadLine()}";

                Console.WriteLine("Место рождения: ");
                note += $"#город {Console.ReadLine()}";

                SWriter.WriteLine(note);
                    Console.Write("Добавить еще одну запись д/н"); k = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(k) == 'д');
            }
                
        }
        static void ReadData()
        {
            using (StreamReader SRead = new StreamReader(@"f:\Igor\Сотрудники.txt", Encoding.UTF8))
            {
                string line;
                Console.WriteLine($"{"ID",2}{" Добавлено",11}{" ФИО",16}");

                while ((line = SRead.ReadLine()) != null )
                {
                    string[] data = line.Split('#');
                    Console.WriteLine($"{data[0],2} {data[1],20} {data[2],14}" +
                        $" {data[3]} {data[4]} {data[5]} {data[6]}");
                }
            }
        }
        static void InitOption(int key)
        {
            if (key == 1)
            {
                ReadData();
            }
            else if (key == 2)
            {
                WriteData();
            }
            else 
            {
                Console.WriteLine("Виберите опцию 1 или 2");
                int initKey = int.Parse(Console.ReadLine());
                InitOption(initKey);
            }
        }
    }
}
