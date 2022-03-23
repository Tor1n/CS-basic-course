using System;
using System.Text;
using System.IO;
using Module6;


namespace module6
{
    class program
    {
        static void Main (string[] args)
        {
            
            string fileName = "Сотрудники.txt";
            int LinesInFile;

            //TempList CurrentList = new TempList(); 

            
            if (File.Exists(fileName))
            {

                LinesInFile = CountFileLines(fileName);
            }
            else
            {
                using (File.Create("Сотрудники.txt"))
                    LinesInFile = 0;
                
            }

            
            Console.WriteLine("Выберите опцию взаимодействия:\n1. Данные по ID;\n2. Добавить сотрудников;\n" +
                "3. Удалить сотрудника по ID;\n4. Изменить данные сотрудника;\n5. Показать записи за период;\n" +
                "6. Отсортировать записи за период;");
            int initKey = int.Parse(Console.ReadLine());
            //InitOption(initKey, fileName, LinesInFile);
            Action(initKey, fileName);
        }

        /// <summary>
        /// Метод инициализации взаимодействий с программой
        /// </summary>
        /// <param name="key">Выбор действия пользователем</param>
        /// <param name="file">Путь к файлу</param>
        static void Action(int key, string file)
        {
            switch (key)
            {
                case 1: //Просмотр записи. Функция должна содержать параметр ID записи, которую необходимо вывести на экран. 
                    Console.Write("Введите ID сотрудника");
                    int ID = int.Parse(Console.ReadLine());
                    ReadData(file);
                    //WorkerById(ID);
                    break;

                case 2: //Создание записи.
                    //AddNewWorker();
                    break;
                case 3: //Удаление записи.
                    //RemoveWorkerByIndex();
                    break;
                case 4: //Редактирование записи.
                    //EditWorkerByID();
                    break;
                case 5: //Загрузка записей в выбранном диапазоне дат.
                    //ShowByAddDate();
                    break;
                case 6: //Сортировка по возрастанию и убыванию даты.
                    //SortByAddDate();
                    break;

                default:
                    break;
            }
        }

        static int CountFileLines(string fileName)
        {
            return File.ReadAllLines(fileName).Length;
        }
        static void WriteData(string fName, int LinesInFile)
        {
            int intCount = LinesInFile;
            
            using (StreamWriter SWriter = new StreamWriter(fName, true, Encoding.UTF8))
            {
                char k = 'д';
                do
                {               
                string note = string.Empty;

                intCount++;
                string stringCount = Convert.ToString(intCount);
                note += stringCount;
                    

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
                    Console.WriteLine("Добавить еще одну запись д/н"); 
                    k = Console.ReadKey(true).KeyChar;
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
                    int i = 0;
                    while ((line = SRead.ReadLine()) != null)
                    {

                        string[] data = line.Split('#');
                        Console.WriteLine($"{data[0],2} {data[1],20} {data[2],14}" +
                            $" {data[3]} {data[4]} {data[5]} {data[6]}");

                        Worker Worker = new Worker()
                        {
                            id = (uint)Convert.ToInt32(data[0]),
                            addDate = Convert.ToDateTime(data[1]),
                            fullName = data[2],
                            age = (uint)Convert.ToInt32(data[3]),
                            height = (uint)Convert.ToInt32(data[4]),
                            birthDate = Convert.ToDateTime(data[5]),
                            birthPlace = data[6]
                        };

                        TempList CurentList = new TempList
                            (new Worker((uint)Convert.ToInt32(data[0]), 
                            Convert.ToDateTime(data[1]), 
                            data[2], 
                            (uint)Convert.ToInt32(data[3]), 
                            (uint)Convert.ToInt32(data[4]), 
                            Convert.ToDateTime(data[5]), 
                            data[6]));
                        
                        Console.WriteLine(CurentList[0]);
                        i++;
                    }
            }
            }
            else
            {
                Console.WriteLine("Файла не существует.");
                
            }
        }
        //static void InitOption(int key, string file, int LinesInFile)
        //{
        //    switch (key)
        //    {
        //        case 1:
        //            ReadData(file);
        //            break;
                    
        //        case 2:
        //            WriteData(file, LinesInFile);
        //            break;
        //        default:
        //            Console.WriteLine("Виберите опцию 1 или 2");
        //            int initKey = int.Parse(Console.ReadLine());
        //            InitOption(initKey, file, LinesInFile);
        //            break;
        //    }
        //    //if (key == 1)
        //    //{
        //    //    ReadData();
        //    //}
        //    //else if (key == 2)
        //    //{
        //    //    WriteData(file);
        //    //}
        //    //else 
        //    //{
        //    //    Console.WriteLine("Виберите опцию 1 или 2");
        //    //    int initKey = int.Parse(Console.ReadLine());
        //    //    InitOption(initKey, file);
        //    //}
        //}
    } 
}
