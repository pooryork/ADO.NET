using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Point2D
    {
        public double x;
        public double y;

        #region constructors

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region properties
        public double X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }
        #endregion

    }
}
