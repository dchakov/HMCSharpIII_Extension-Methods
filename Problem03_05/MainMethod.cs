//Problem 3. First before last• Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//• Use LINQ query operators.
//Problem 4. Age range• Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//Problem 5. Order students• Using the extension methods  OrderBy()  and  ThenBy()  with lambda expressions sort the students by first name and last name in descending order.
//• Rewrite the same with LINQ.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem03_05
{
    class MainMethod
    {
        static void Main()
        {
            Student[] arrStudents =
            {
                new Student("Ivan","Ivanov",23),
                new Student("Asen","Nikolov",18),
                new Student("Nedqlko","Georgiev",19),
                new Student("Dimitar","Asenov",29),
                new Student("Dimitar","Kolev",24),
                new Student("Ivan","Petkov",25)
            };
            var firstBeforeLast = FirstNameBeforeLast(arrStudents);
            PrintCollection(firstBeforeLast);
            
            Console.WriteLine();
            var ageRange =
                from names in arrStudents
                where names.Age >= 18 && names.Age <= 24
                select new { names.FirstName, names.LastName };

            PrintCollection(ageRange);
           
            Console.WriteLine();
            var orderStudentsMethod = arrStudents
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(y => y.LastName);

            PrintCollection(orderStudentsMethod);
            
            Console.WriteLine();
            var orderStudents =
                from students in arrStudents
                orderby students.FirstName descending,students.LastName descending
                select students;
            PrintCollection(orderStudents);
        }
        public static IEnumerable<Student> FirstNameBeforeLast(Student[] students)
        {
            return from names in students
                   where names.FirstName.CompareTo(names.LastName) < 0
                   select names;
        }
        private static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

    }
}
