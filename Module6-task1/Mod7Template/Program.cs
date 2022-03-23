using System;
using System.Text;
using System.IO;
using Mod7Template;



namespace Mod7Template
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Сотрудники.txt";

            if (!File.Exists(path)) //Создаем дефолтный файл в случае отсутсвия
            {
                using (File.Create(path));
                File.AppendAllText(path, "0#23.03.2022 18:41:08#Илья Щербин#41#185#18.11.1981#Севастополь\n" +
                    "1#20.12.2021 00:12#Иванов Иван Иванович#30#176#05.05.1992#Москва\n" +
                    "2#15.12.2021 03:12#Алексеев Алексей Иванович#44#176#05.11.1980#Томск\n");
            }
            
            Repository rep = new Repository(path); //Заносим данные из файла в буфер

            Console.Write("Выбирите действие:\n1.Просмотр данных\n2.Добавление новой записи\n" +
                "3.Редактирование записи по ID\n");

            int key = int.Parse(Console.ReadLine());
            switch (key)
            {
                case 1: //Выводим все данные из буфера на экран
                    rep.PrintDbToConsole(); 
                    Console.WriteLine($"Записей в файле: {rep.Count}");
                    break;
                case 2: //Добавляем новую запись
                    Console.Write("Имя: ");
                    string newName = Console.ReadLine();
                    Console.Write("Возраст: ");
                    uint newAge = uint.Parse(Console.ReadLine());
                    Console.Write("Рост: ");
                    uint newHeight = uint.Parse(Console.ReadLine());
                    Console.Write("Дата Рождения: ");
                    DateTime newBirthDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Место Рождения: ");
                    string newPlace = Console.ReadLine();

                    rep.Add(new Worker((uint)rep.Count, DateTime.Now, newName, newAge, newHeight, newBirthDate, newPlace));
                    break;
                case 3: //Редактируем запись по ID
                    Console.WriteLine("Укажите ID сотрудника, данные которого необходимо отредактировать: ");
                    int editID = int.Parse(Console.ReadLine());
                    rep.PrintDataByID(editID);
                    Console.WriteLine("Какие данные необходимо отредактировать?" +
                        "\n1.Имя\n2.Возраст\n3.Рост\n4.Дату рождения\n5.Место рождения");
                    int editKey = int.Parse(Console.ReadLine());
                    switch (editKey)
                    {
                        case 1:
                            Console.Write("Введите новые данные имени: ");
                            string nName = Console.ReadLine();
                            rep.EditName(editID, nName);
                            Console.WriteLine("Данные успешно перезаписаны.");
                            break;
                        case 2:
                            Console.Write("Введите новые данные возраста: ");
                            uint nAge = uint.Parse(Console.ReadLine());
                            rep.EditAge(editID, nAge);
                            Console.WriteLine("Данные успешно перезаписаны.");
                            break;
                        case 3:
                            Console.WriteLine("Введите новые данные роста: ");
                            uint nHeight = uint.Parse(Console.ReadLine());
                            rep.EditHeight(editID, nHeight);
                            Console.WriteLine("Данные успешно перезаписаны.");
                            break;
                        case 4:
                            Console.WriteLine("Введите новую дату рождения: ");
                            DateTime nBDate = DateTime.Parse(Console.ReadLine());
                            rep.EditBDate(editID, nBDate);
                            Console.WriteLine("Данные успешно перезаписаны.");
                            break;
                        case 5:
                            Console.WriteLine("Введите новое место рождения: ");
                            string nBPlace = Console.ReadLine();
                            rep.EditBPlace(editID, nBPlace);
                            Console.WriteLine("Данные успешно перезаписаны.");
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }

            //rep.Add(new Worker((uint)rep.Count, DateTime.Now, "Здесь имя", 31, 185, DateTime.Now, "Город"));
            rep.Save("Сотрудники.txt");

            Console.ReadKey();
        }
        //static void Action()
        //{
        //    Console.WriteLine("Выбирите действие:\n1.Просмотр данных");
        //    int key = int.Parse(Console.ReadLine());

        //    switch (key)
        //    {
        //        case 1:
        //            rep.PrintDbToConsole(); //Не понимаю почему не видит структуру в отдельном методе.
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
