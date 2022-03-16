using System;
using System.Text;
using System.IO;

namespace module6
{
    internal class program
    {
        static void Main(string[] args)
        {

            string fileName = "Сотрудники.txt";
            //int newCount;
            //if (File.Exists(fileName))
            //{
            //    newCount = File.ReadAllLines(fileName).Length;
            //}
            //else
            //{
            //    newCount = 0;
            //}


            Console.WriteLine("Для просмотра данных нажмите 1, для добавления нажмите 2");
            int initKey = int.Parse(Console.ReadLine());
            InitOption(initKey, fileName);
        }
        static void WriteData(string fName)
        {
            using (StreamWriter SWriter = new StreamWriter(fName, true, Encoding.UTF8))
            {
                char k = 'д';
                do
                {
                    string note = string.Empty;
                    int newCount;
                    if (File.Exists(fName))
                    {
                        newCount = File.ReadAllLines(fName).Length;
                    }
                    else
                    {
                        newCount = 0;
                    }
                    int intCount = newCount + 1;
                    string strCount = Convert.ToString(intCount);
                    note += strCount;

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
                    Console.WriteLine("Добавить еще одну запись д/н"); k = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(k) == 'д');
            }

        }
        static void ReadData(string fName)
        {
            if (File.Exists(fName))
            {
                using (StreamReader SRead = new StreamReader(fName, Encoding.UTF8))
                {
                    string line;
                    Console.WriteLine($"{"ID",2}{" Добавлено",11}{" ФИО",16}");

                    while ((line = SRead.ReadLine()) != null)
                    {
                        string[] data = line.Split('#');
                        Console.WriteLine($"{data[0],2} {data[1],20} {data[2],14}" +
                            $" {data[3]} {data[4]} {data[5]} {data[6]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Файла не существует.");

            }
        }
        static void InitOption(int key, string file)
        {
            switch (key)
            {
                case 1:
                    ReadData(file);
                    break;

                case 2:
                    WriteData(file);
                    break;
                default:
                    Console.WriteLine("Виберите опцию 1 или 2");
                    int initKey = int.Parse(Console.ReadLine());
                    InitOption(initKey, file);
                    break;
            }
            //if (key == 1)
            //{
            //    ReadData();
            //}
            //else if (key == 2)
            //{
            //    WriteData(file);
            //}
            //else 
            //{
            //    Console.WriteLine("Виберите опцию 1 или 2");
            //    int initKey = int.Parse(Console.ReadLine());
            //    InitOption(initKey, file);
            //}
        }
    }
}
