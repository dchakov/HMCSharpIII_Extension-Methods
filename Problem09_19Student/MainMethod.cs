using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem09_19Student
{
    public class MainMethod
    {
        public static List<Student> arrStudents = new List<Student>
            {
                new Student("Ivan","Ivanov",122004,"+35929673456","ivan@yahoo.com",new List<int>{2,4,2,4},2),
                new Student("Asen","Nikolov",321706,"+35932673456","asen@abv.bg",new List<int>{4,5},1),
                new Student("Nedqlko","Georgiev",278305,"+35932666479","ivan@gmail.com",new List<int>{2,2,2},3),
                new Student("Dimitar","Asenov",222306,"+35924563345","dimitar@abv.bg",new List<int>{6,6,5},1),
                new Student("Dimitar","Kolev",112207,"+35952673456","kolev@yahoo.com",new List<int>{5,2,5,2,6},2),
                new Student("Ivan","Petkov",698507,"+35956973456","ivan_pe@fortbg.com",new List<int>{4,4,4},2)
            };
        public static List<Group> department = new List<Group>
            {
                new Group(1,"Mathematics"),
                new Group(2,"Informatics"),
                new Group(3,"Physics")
            };

        public static void Main()
        {
            Console.BufferHeight = Console.BufferHeight = 60;
            //Problem 9. Student groups
            //Create a List<Student> with sample students. 
            //Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.
                        
            PrintCollection(arrStudents);

            var studentsByGroupeNumber =
                from student in arrStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            Console.WriteLine();
            Console.WriteLine("Students by group number 2");
            PrintCollection(studentsByGroupeNumber);

            // Problem 10. Student groups extensions
            //Implement the previous using the same query expressed with extension methods.

            Console.WriteLine();
            Console.WriteLine("Students by group number 2 - extension method");
            var studentsByGroupeNumberMethod = arrStudents.StudentByGroupNumber(2);
            PrintCollection(studentsByGroupeNumberMethod);

            //Problem 11. Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.
            Console.WriteLine();
            Console.WriteLine("Extract students by email");
            var studentByEmail = arrStudents.ExtractStudentsByEmail("@abv.bg");
            PrintCollection(studentByEmail);
                        
            //Problem 12. Extract students by phone• Extract all students with phones in Sofia.
            //• Use LINQ.
            Console.WriteLine();
            Console.WriteLine("Extract students by phone");
            var extractByPhone =
                from stud in arrStudents
                where stud.Tel.StartsWith("+3592")
                select stud;
            PrintCollection(extractByPhone);
          
            //Problem 13. Extract students by marks• Select all students that have at least one mark  Excellent  ( 6 )
            //into a new anonymous class that has properties –  FullName  and  Marks .
            //• Use LINQ.
            Console.WriteLine();
            Console.WriteLine("Extract students by marks");
            var extractByMark =
                from stud in arrStudents
                where stud.Marks.Contains(6)
                select new { FullName = stud.FirstName + " " + stud.LastName, Marks = string.Join(",",stud.Marks) };
            PrintCollection(extractByMark);
              
            //Problem 14. Extract students with two marks• Write down a similar program that extracts the students with exactly two marks " 2 ".
            //• Use extension methods.
            Console.WriteLine();
            Console.WriteLine("Extract students with two marks 2");
            var extractByTwoMarks = arrStudents.ExtractStudentWithTwoMarks(2, 2);
            PrintCollection(extractByTwoMarks);

            //Problem 15. Extract marks• Extract all  Marks  of the students that enrolled in 2006. 
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine();
            Console.WriteLine("Extract all  Marks from 2006");
            var extractAllMarks =
                from stud in arrStudents
                where stud.FN.ToString().Substring(4, 2) == "06"
                select string.Join(",",stud.Marks);
            PrintCollection(extractAllMarks);
           
            //Problem 16.* Groups• Create a class  Group  with properties  GroupNumber  and  DepartmentName .
            //• Introduce a property  GroupNumber  in the  Student  class.
            //• Extract all students from "Mathematics" department.
            //• Use the  Join  operator.
            Console.WriteLine();
            Console.WriteLine("Mathematics department");
            
            var extractMathematics =
                from depar in department
                where depar.DepartmentName == "Mathematics"
                join stud in arrStudents
                on depar.GroupNumber equals stud.GroupNumber
                select stud;
            PrintCollection(extractMathematics);

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
