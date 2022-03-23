using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mod7Template
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
            return $"{this.id} {this.addDate} {this.fullName}, возраст:{this.age}, " +
                $"рост:{this.height}, родился {this.birthDate.ToShortDateString()} в городе {this.birthPlace}";
        }

        //public string SortByDate()
        //{
            
            
        //}

        #endregion

        #region Свойства

        /// <summary>
        /// ID
        /// </summary>
        public uint ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        /// <summary>
        /// Дата добавления записи
        /// </summary>
        public DateTime AddDate
        {
            get { return this.addDate; }
            set { this.addDate = value; }
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string FullName 
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }
        /// <summary>
        /// Возраст
        /// </summary>
        public uint Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        /// <summary>
        /// Рост
        /// </summary>
        public uint Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        /// <summary>
        /// Дата Рождения
        /// </summary>
        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        /// <summary>
        /// Место Рождения
        /// </summary>
        public string BirthPlace
        {
            get { return this.birthPlace; }
            set { this.birthPlace = value; }
        }


        #endregion


    }
}
