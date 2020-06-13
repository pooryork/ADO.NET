using System;
using System.IO;
namespace Task1
{

    public class Program
    {
        static void Main()
        {
            fileLib file = new fileLib();
            Triangle[] ar = file.input(@"../../../../Files/input.txt");
            file.output(ar, @"../../../../Files/output.txt");
            foreach (Triangle item in ar)
            {
                Console.WriteLine(item.show());
                Console.WriteLine("Периметр - " + item.P);
                Console.WriteLine("Площадь - " + item.S);
                Console.WriteLine();
            }

        }
    }
}