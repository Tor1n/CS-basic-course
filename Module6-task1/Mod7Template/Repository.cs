using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod7Template;

namespace Mod7Template
{
    /// <summary>
    /// Структура по работе с данными
    /// </summary>
    struct Repository
    {
        private Worker[] workers; // Основной массив для хранения данных

        private string path; // путь к файлу с данными

        int index; // текущий элемент для добавления в workers

        string[] titles; // массив, храняий заголовки полей. Пока не работает

        /// <summary>
        /// Констрктор
        /// </summary>
        /// <param name="Path">Путь в файлу с данными</param>
        public Repository(string Path)
        {
            this.path = Path; // Сохранение пути к файлу с данными
            this.index = 0; // текущая позиция для добавления сотрудника в workers
            this.titles = new string[0]; // инициализаия массива заголовков. Пока не работает
            this.workers = new Worker[2]; // инициализаия массива сотрудников.  

            this.Load(); // Загрузка данных
        }

        /// <summary>
        /// Метод увеличения текущего хранилища
        /// </summary>
        /// <param name="Flag">Условие увеличения</param>
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }

        /// <summary>
        /// Метод добавления сотрудника в хранилище
        /// </summary>
        /// <param name="ConcreteWorker">Сотрудник</param>
        public void Add(Worker ConcreteWorker)
        {
            this.Resize(index >= this.workers.Length);
            this.workers[index] = ConcreteWorker;
            this.index++;
        }

        /// <summary>
        /// Метод загрузки данных
        /// </summary>
        private void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');

                    Add(new Worker((uint)Convert.ToInt32(args[0]), Convert.ToDateTime(args[1]), 
                        args[2], (uint)Convert.ToUInt32(args[3]), (uint)Convert.ToUInt32(args[4]), 
                        Convert.ToDateTime(args[5]), args[6]));
                }
            }
        }

        /// <summary>
        /// Метод сохранения данных
        /// </summary>
        /// <param name="Path">Путь к файлу сохранения</param>
        public void Save(string Path)
        {
            File.Delete(Path);

            for (int i = 0; i < this.index; i++)
            {
               string temp = String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                        this.workers[i].ID,
                                        this.workers[i].AddDate,
                                        this.workers[i].FullName,
                                        this.workers[i].Age,
                                        this.workers[i].Height,
                                        this.workers[i].BirthDate,
                                        this.workers[i].BirthPlace);
               File.AppendAllText(Path, $"{temp}\n");
            }
        }
        public void DeletionSave(string Path, uint j) //Принимает так же индекс который нужно исключить из файла
        {
            File.Delete(Path);

            for (int i = 0; i < this.index; i++)
            {
                if (i == j)
                {
                    continue;
                }
                else
                {
                    
                    string temp = String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                         this.workers[i].ID, 
                                         this.workers[i].AddDate,
                                         this.workers[i].FullName,
                                         this.workers[i].Age,
                                         this.workers[i].Height,
                                         this.workers[i].BirthDate,
                                         this.workers[i].BirthPlace);
                    File.AppendAllText(Path, $"{temp}\n");
                }
                
            }
        }
        /// <summary>
        /// Вывод данных в консоль
        /// </summary>
        public void PrintDbToConsole()
        {            
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.workers[i].Print());
            }
        }
        public void PrintDbByPeriod(DateTime From, DateTime Till)
        {            
            for (int i = 0; i < index; i++)
            {
                if (workers[i].AddDate > From && Till > workers[i].AddDate)
                {
                    Console.WriteLine(this.workers[i].Print());
                }
                
            }
        }
        public void PrintDataByID(int i)
        {
            Console.WriteLine(this.workers[i].Print());            
        }

        public void EditName(int i, string n)
        {
            workers[i].FullName = n;
        }

        public void EditAge(int i, uint n)
        {
            workers[i].Age = n;
        }

        public void EditHeight(int i, uint n)
        {
            workers[i].Height = n;
        }
        public void EditBDate(int i, DateTime n)
        {
            workers[i].BirthDate = n;
        }
        public void EditBPlace(int i, string n)
        {
            workers[i].BirthPlace = n;
        }

        /// <summary>
        /// Количество сотрудников в хранилище
        /// </summary>
        public int Count { get { return this.index; } }

        public void SortByBDate() //Сортировка по дате рождения
        {
            var people = workers;
            var sortedPeople1 = from p in people
                                orderby p.BirthDate
                                select p;

            foreach (var p in sortedPeople1)
                Console.WriteLine($"ID:{p.ID} Родился:{p.BirthDate} - {p.FullName} - Рост: {p.Height}");
        } 
        public void SortByDateAdded() //Сортировка по дате добавления
        {
            var people = workers;
            var sortedPeople1 = from p in people
                                orderby p.AddDate
                                select p;

            foreach (var p in sortedPeople1)
                Console.WriteLine($"ID:{p.ID} Добавлен {p.AddDate} Возраст:{p.Age} - {p.FullName} - Рост: {p.Height}");


        }
        public void SortByDateAddedDes() //Сортировка по дате добавления
        {
            var people = workers;
            var sortedPeople1 = from p in people
                                orderby p.AddDate descending
                                select p;

            foreach (var p in sortedPeople1)
                Console.WriteLine($"ID:{p.ID} Добавлен {p.AddDate} Возраст:{p.Age} - {p.FullName} - Рост: {p.Height}");


        }

    }
}
