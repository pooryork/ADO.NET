using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Task1
{
    public class fileLib
    {
        public Triangle[] input(string path)
        {
            Triangle[] ar = null;
            Triangle tr = new Triangle();
            using (StreamReader fileIn = new StreamReader(path))
            {
                int n;
                if (int.TryParse(fileIn.ReadLine(), out n))
                {
                    ar = new Triangle[n];

                    for (int i = 0; i < n; i++)
                    {
                        string[] text = fileIn.ReadLine().Split(' ');
                        double x;
                        double y;
                        Point2D A = null;
                        Point2D B = null;
                        Point2D C = null;

                        if (double.TryParse(text[0], out x) && double.TryParse(text[1], out y))
                        {
                            A = new Point2D(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Неверный тип передваемого параметра");
                        }

                        if (double.TryParse(text[2], out x) && double.TryParse(text[3], out y))
                        {
                            B = new Point2D(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Неверный тип передваемого параметра");
                        }


                        if (double.TryParse(text[4], out x) && double.TryParse(text[5], out y))
                        {
                            C = new Point2D(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Неверный тип передваемого параметра");
                        }

                        ar[i] = new Triangle(A, B, C);
                    }
                }
                return ar;
            }
        }
        public void output(Triangle[] ar)
        {
            using (StreamWriter fileOut = new StreamWriter("output.txt"))
            {
                foreach (Triangle item in ar)
                {
                    fileOut.WriteLine("a = (" + item.a.x + "," + item.a.y + ")");
                    fileOut.WriteLine("b = (" + item.b.x + "," + item.b.y + ")");
                    fileOut.WriteLine("c = (" + item.c.x + "," + item.c.y + ")");
                    fileOut.WriteLine("Периметр - " + item.P);
                    fileOut.WriteLine("Площадь - " + item.S);
                    fileOut.WriteLine();
                }
            }
        }
    }
}
