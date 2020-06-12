using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Book
    {
        #region fields
        private string name;
        private int pages;
        private string publisher;
        private DateTime? publicationDate;
        private DateTime? writtenDate;
        private Author author;
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
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    throw new ArgumentException("Некорретное значение количества страниц!");
                }
            }
        }
        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                if (value != null)
                {
                    publisher = value;
                }
                else
                {
                    throw new ArgumentException("Некорректное название издателя!");
                }
            }
        }        
        public DateTime? PublicationDate
        {
            get
            {
                return publicationDate;
            }
            set
            {
                if (value != null)
                {
                    publicationDate = value;
                }
                else
                {
                    throw new ArgumentException("Некорректная дата!");
                }
            }
        }
        public DateTime? WrittenDate
        {
            get
            {
                return writtenDate;
            }
            set
            {
                if (value != null && value <= publicationDate)
                {
                    writtenDate = value;
                }
                else
                {
                    throw new ArgumentException("Некорректная дата!");
                }
            }
        }
        public Author Author
        {
            get
            {
                return author;
            }
            set
            {
                if (value != null && value.BirthYear <= ((DateTime)WrittenDate).Year)
                {
                    author = value;
                }
                else
                {
                    throw new ArgumentException("Дата рождения не может быть позже даты написания книги!");
                }
            }
        }
        #endregion

        #region constructors
        public Book(string name, int pages, string publisher, DateTime? publicationDate, DateTime? writtenDate, Author author)
        {
            Name = name;
            Pages = pages;
            Publisher = publisher;
            PublicationDate = publicationDate;
            WrittenDate = writtenDate;
            Author = author;
        }
        #endregion

        #region override
        public override string ToString()
        {
            return this.name + ", " + this.pages + " стр, издатель - " +  this.publisher +
                ", дата публикации -  " + this.publicationDate + ", дата выхода - " + this.writtenDate +
                ", автор - " + Author.ToString();
        }
        #endregion
    }
}
