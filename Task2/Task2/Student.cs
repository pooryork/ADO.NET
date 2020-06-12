using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Student: Man
    {
        #region fields
        private int admissionYear;        
        private int course;      
        private int group;
        #endregion

        #region properties
        public int AdmissionYear
        {
            get
            {
                return this.admissionYear;
            }
            set
            {
                if (value >= 1800)
                {
                    this.admissionYear = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }
        public int Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (value > 0)
                {
                    this.course = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }
        public int Group
        {
            get
            {
                return this.group;
            }
            set
            {
                if ((value > 0))
                {
                    this.group = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }
        #endregion

        #region constructors
        public Student ():base() { }
        public Student(string name, int age, double weight, double highth, int admissionYear, int course,
            int group) : base(name, age, weight, highth)
        {
            AdmissionYear = admissionYear;
            Course = course;
            Group = group;
        }
        #endregion

        #region override
        public override string ToString()
        {
            //return $"{Name} { Age} { Weight} { Hight} { AdmissionYear} { Course} { Group}";
            return base.ToString() + ", " + this.admissionYear + " admission year, " + this.course +
                " cource, " + this.group + " group";
        }
        #endregion

    }
}
