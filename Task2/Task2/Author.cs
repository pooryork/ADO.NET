using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Author
    {
        #region fields
        private string name;     
        private string surname;
        private int birthYear;
        #endregion

        #region properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Некорректное имя!");
                }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != null)
                {
                    surname = value;
                }
                else
                {
                    throw new ArgumentException("Некорретное имя!");
                }
            }
        }        
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                if (value >= 0 && birthYear <= DateTime.Now.Year)
                {
                    birthYear = value;
                }
                else
                {
                    throw new ArgumentException("Некорректный год рождения автора!");
                }
            }
        }
        #endregion

        #region constructors
        public Author(string newName, string newSurname, int newBirthYear)
        {
            Name = newName;
            Surname = newSurname;
            BirthYear = newBirthYear;
        }
        #endregion

        #region override
        public override string ToString()
        {
            return Name + " " + Surname + " " + BirthYear;
        }
        #endregion
    }
}
