using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            fileLib file = new fileLib();

            Console.WriteLine("Task 1:");

            List<Student> ar = file.inputStudents(@"../../../../Files/students.txt");
            foreach (Student item in ar)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("");

            Console.WriteLine("Task 2:");

            List<Book> ar1 = file.inputBooks(@"../../../../Files/books.txt");
            foreach (Book item in ar1)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("");


        }
    }
}
