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
            Check(path);
            Repository rep = new Repository(path); //Заносим данные из файла в буфер
            
            Action(path, rep);
            Console.ReadKey();
        }
        static void Action(string path, Repository rep) //Метод вырора действия пользователем
        {
            Console.WriteLine("Выбирите действие:\n1.Просмотр данных\n2.Добавление новой записи\n" +
                "3.Редактирование записи по ID\n4.Дата добаления по убыванию\n5.Дата добавления по возрастанию\n" +
                "6.Записи добавленные за период\n7.Удаление записи по ID\n8.Cортировать по дате рождения");

            int key = int.Parse(Console.ReadLine());
            switch (key)
            {
                case 1: //Выводим все данные из буфера на экран
                    rep.PrintDbToConsole();
                    Console.WriteLine($"Записей в файле: {rep.Count}");
                    break;
                case 2: //Добавляем новую запись

                    char k = 'д';
                    do
                    {
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
                        Console.WriteLine("Запись добавлена. Желаете добавить еще одну? д/н");
                        k = Console.ReadKey(true).KeyChar;
                    } while (char.ToLower(k) == 'д');
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
                case 4:
                    rep.SortByDateAddedDes(); //Сортировка по дате добавления по убыванию
                    break;
                case 5:
                    rep.SortByDateAdded(); //Сортировка по дате добавления по возрастанию
                    break;
                case 6:
                    Console.WriteLine("Дата от которой вывести записи: ");
                    DateTime from = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Дата до которой вывести записи: ");
                    DateTime till = DateTime.Parse(Console.ReadLine());
                    rep.PrintDbByPeriod(from, till); //Вывод записей добавленных за период
                    break;
                case 7:
                    rep.PrintDbToConsole();
                    Console.WriteLine("введите ID записи которую необходимо удалить:");
                    break;
                case 8:
                    rep.SortByBDate(); //Сортировка по дате рождения
                    break;
                default:
                    break;
            }
            Finish(key, rep);
        }
        static void Finish(int key, Repository rep) //Метод сохранения изменений из буфера в файл
        {
            if (key == 7)
            {
                uint delIndex = uint.Parse(Console.ReadLine());
                rep.DeletionSave("Сотрудники.txt", delIndex);
                Console.WriteLine("Запить успешно удалена.");
            }
            else
            {
                rep.Save("Сотрудники.txt");
            }
        }
        static void Check(string path) //При отсутсвии файла просим добавить сотрудника
        {
            if (!File.Exists(path)) 
            {
                Console.WriteLine("В файле еще нет данных, для добавления сотрудника нажмите 2\n");                
                using (File.Create(path));
            }

        }
    }
}
