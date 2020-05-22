using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task1
{
    public class Triangle
    {
        #region fields
        //  координаты вершин
        public Point2D a;
        public Point2D b;
        public Point2D c;

        //  площадь
        public double S
        {
            get
            {
                return Math.Sqrt(P / 2 * (P / 2 - pathLength(a, b)) * (P / 2 - pathLength(b, c)) * (P / 2 - pathLength(c, a)));
            }
            set
            {
                S = Math.Sqrt(P / 2 * (P / 2 - pathLength(a, b)) * (P / 2 - pathLength(b, c)) * (P / 2 - pathLength(c, a)));
            }
        }

        //  периметр
        public double P
        {
            get
            {
                return pathLength(a, b) + pathLength(b, c) + pathLength(c, a);
            }
            set
            {
                P = pathLength(a, b) + pathLength(b, c) + pathLength(c, a);
            }
        }
        #endregion

        #region constructors
        public Triangle() { }

        public Triangle(Point2D a, Point2D b, Point2D c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            //  проверяем, что треуголник существует
            if (!_checkTriangular())
            {
                throw new Exception("Такого треугольника не существует!");
            }
        }

        #endregion

        #region functions
        //  проверка существования трегольника с вершинами в заданных точках
        private bool _checkTriangular()
        {
            double length1 = pathLength(a, b);
            double length2 = pathLength(c, b);
            double length3 = pathLength(a, c);

            //  треугольник существует тогда и только тогда, когда сумма длинн каждых двух сторон больше длинны
            if ((length1 + length2 > length3) && (length1 + length3 > length2) && (length2 + length3 > length1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //  длина стороны
        public double pathLength(Point2D p1, Point2D p2)
        {
            return Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
        }

        public string show()
        {
            return "a = (" + a.x + "," + a.y + ")\nb = (" + b.x + "," + b.y + ") \nc = (" + c.x + "," + c.y + ")";
        }
        #endregion

    }
}
