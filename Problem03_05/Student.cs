using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem03_05
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName 
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Student(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}",this.firstName,this.lastName,this.age);
        }
        
    }
}
