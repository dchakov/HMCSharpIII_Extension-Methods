using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem09_19Student
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int fn;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty");
                }
                this.lastName = value;
            }
        }
        public int FN
        {
            get { return this.fn; }
            private set
            {
                if (value <0)
                {
                    throw new ArgumentException("Must be positive");
                }
                this.fn = value;
            }
        }
        public string Tel
        {
            get { return this.tel; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty");
                }
                this.tel = value; 
            }
        }
        public string Email
        {
            get { return this.email; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty");
                }
                this.email = value; 
            }
        }
        public List<int> Marks
        {
            get { return this.marks; }
            private set
            { 
                this.marks = value; 
            }
        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Must be positive");
                }
                this.groupNumber = value; 
            }
        }

        public Student(string firstName, string lastName, int fn, string tel,
            string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} Group number = {6}",
                this.firstName, this.lastName, this.fn,
                this.tel, this.email, string.Join(",", this.marks), this.groupNumber);
        }
    }
}
