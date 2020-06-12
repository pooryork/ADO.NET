using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Man
    {
        #region fileds
        private string name;      
        private int age;        
        private double weight;        
        private double hight;
        #endregion

        #region properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Некорректное значение возраста!");
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 16)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Некорректное значение возраста!");
                }
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException("Некорректное значение веса!");
                }
            }
        }
        public double Hight
        {
            get
            {
                return this.hight;
            }
            set
            {
                if (value > 0)
                {
                    this.hight = value;
                }
                else
                {
                    throw new ArgumentException("Некорректное значение роста!");
                }
            }
        }
        #endregion

        #region constructors
        public Man() { }
        public Man(string name, int age, double weight, double hight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Hight = hight;
        }
        #endregion

        #region override
        public override string ToString()
        {
            return this.name + ", " + this.age + " years, " + Weight + " kg, " + Hight + " m";
        }
        #endregion
    }
}
