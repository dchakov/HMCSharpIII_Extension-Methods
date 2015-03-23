using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem09_19Student;

namespace Problem18_19Groupe
{
    public class GroupedByGroup
    {
        public static void Main()
        {
            //Problem 18. Grouped by GroupNumber• Create a program that extracts all students grouped
            //by  GroupNumber  and then prints them to the console.
            //• Use LINQ.
            Console.WriteLine("Use LINQ");
            var groupedByGroupNumber =
                from stud in MainMethod.arrStudents
                group stud by stud.GroupNumber into groups
                select new { Grouped = groups.Key, Students = groups };

            foreach (var groups in groupedByGroupNumber)
            {
                Console.WriteLine(groups.Grouped);
                foreach (var item in groups.Students)
                {
                    Console.WriteLine(item);
                }
            }

            //Problem 19. Grouped by GroupName extensions• Rewrite the previous using extension methods.
            Console.WriteLine();
            Console.WriteLine("using extension methods");
            var groupeByGroupName =
                MainMethod.arrStudents.GroupBy(x => x.GroupNumber, (groupNumber, students) => new {Group = groupNumber,Students = students });

            foreach (var groups in groupeByGroupName)
            {
                Console.WriteLine(groups.Group);
                foreach (var item in groups.Students)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

