using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module6
{
    struct Worker
    {
        #region Поля

        /// <summary>
        /// Поле "ID"
        /// </summary>
        public uint id;

        /// <summary>
        /// Поле "Дата добавления записи"
        /// </summary>
        public DateTime addDate;

        /// <summary>
        /// Поле "Имя"
        /// </summary>
        public string fullName;

        /// <summary>
        /// Поле "Возраст"
        /// </summary>
        public uint age;

        /// <summary>
        /// Поле "Рост"
        /// </summary>
        public uint height;

        /// <summary>
        /// Поле "Дата Рождения"
        /// </summary>
        public DateTime birthDate;

        /// <summary>
        /// Поле "Место рождения"
        /// </summary>
        public string birthPlace;

        #endregion

        #region Конструкторы

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="AddDate">Дата добавления записи</param>
        /// <param name="FullName">Имя</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="BirthDate">Дата Рождения</param>
        /// <param name="BirthPlace">Место рождения</param>
        public Worker(uint ID, DateTime AddDate,  string FullName, uint Age, uint Height, DateTime BirthDate, string BirthPlace)
        {
            this.id = ID;
            this.addDate = AddDate;
            this.fullName = FullName;
            this.age = Age;
            this.height = Height;
            this.birthDate = BirthDate;
            this.birthPlace = BirthPlace;
        }

        #endregion

        #region Методы

        public string Print()
        {
            return $"{this.id} {this.addDate} {this.fullName} {this.age} {this.height} {this.birthDate}{this.birthPlace}";
        }

        #endregion

        #region Свойства

        /// <summary>
        /// Имя
        /// </summary>
        public string FullName 
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public string WorkerById()
        {
              return this.fullName; 
        }
        /// <summary>
        /// Возраст
        /// </summary>
        //public uint Age { get; set; }

        /// <summary>
        /// Должность
        /// </summary>



        #endregion


    }
}
