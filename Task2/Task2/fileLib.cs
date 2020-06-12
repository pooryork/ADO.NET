using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Task2
{
    class fileLib
    {
        public List<Student> inputStudents(string path)
        {
            using (StreamReader fileIn = new StreamReader(path))
            {
                List<Student> ar = new List<Student>();
                string document = fileIn.ReadToEnd();
                string[] lines = document.Split("\n");

                foreach (var line in lines)
                {

                    bool isParsed = false;
                    string[] strs = line.Split(" ");

                    string name = strs[0];
                    isParsed = int.TryParse(strs[1], out int age);
                    if (!isParsed)
                    {
                        throw new ArgumentException("Некорретное значение возраста!");
                    }
                    isParsed = double.TryParse(strs[2], out double weight);
                    if (!isParsed)
                    {
                        throw new ArgumentException("Некорретное значение веса!");
                    }
                    isParsed = double.TryParse(strs[3], out double hight);
                    if (!isParsed)
                    {
                        throw new ArgumentException("Некорретное значение роста!");
                    }
                    isParsed = int.TryParse(strs[4], out int admissionYear);
                    if (!isParsed)
                    {
                        throw new ArgumentException("Некорретное значение года!");
                    }
                    isParsed = int.TryParse(strs[5], out int cource);
                    if (!isParsed)
                    {
                        throw new ArgumentException("Некорретное значение номера курса!");
                    }
                    isParsed = int.TryParse(strs[6], out int group);
                    if (!isParsed)
                    {
                        throw new ArgumentException("Некорретное значение номера группы!");
                    }

                    Student tmp = new Student(name, age, weight, hight, admissionYear, cource, group);

                    ar.Add(tmp);
                }
                return ar;
            }
        }

        public List<Book> inputBooks(string path)
        {
            using (StreamReader fileIn = new StreamReader(path))
            {
                List<Book> ar = new List<Book>();

                string document = fileIn.ReadToEnd();
                string[] lines = document.Split("\n");

                foreach (var line in lines)
                {
                    bool isParsed = false;
                    string[] strs = line.Split("; ");

                    string name = strs[0];
                    string publisher = strs[1];
                    isParsed = int.TryParse(strs[2], out int pages);
                    if (!isParsed)
                    {
                        throw new ArgumentException("Некорретное значение количества страниц!");
                    }
                    string datePublish = strs[3];
                    string[] datesPublish = datePublish.Split("-");
                    if (!int.TryParse(datesPublish[0], out int date1) || !int.TryParse(datesPublish[1],
                        out int date2) || !int.TryParse(datesPublish[2], out int date3))
                    {
                        throw new ArgumentException("Некорретное значение даты публикации!");
                    }
                    string dateWritten = strs[4];
                    string[] datesWritten = dateWritten.Split("-");
                    if (!int.TryParse(datesWritten[0], out int date4) || !int.TryParse(datesWritten[1],
                        out int date5) || !int.TryParse(datesWritten[2], out int date6))
                    {
                        throw new ArgumentException("Некорретное значение даты написания!");
                    }
                    string authorName = strs[5];
                    string authorSurname = strs[6];
                    isParsed = int.TryParse(strs[7], out int year);
                    if (!isParsed)
                    {
                        throw new ArgumentException("Некорретное значение года рождения автора!");
                    }

                    Author author = new Author(authorName, authorSurname, year);
                    Book book = new Book(name, pages, publisher, new DateTime(date1, date2, date3), new DateTime(date4, date5, date6), author);

                    ar.Add(book);
                }

                return ar;
            }
        }
    }
}
