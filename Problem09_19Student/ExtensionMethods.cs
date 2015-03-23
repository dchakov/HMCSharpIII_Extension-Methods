using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem09_19Student
{
    public static class ExtensionMethods
    {
        public static IEnumerable<Student> StudentByGroupNumber(this IEnumerable<Student> arrStudent, int num)
        {
            return from stud in arrStudent
                   where stud.GroupNumber == num
                   orderby stud.FirstName
                   select stud;
        }
        public static IEnumerable<Student> ExtractStudentsByEmail(this IEnumerable<Student> arrStudent, string str)
        {
            return from stud in arrStudent
                   where stud.Email.Contains(str)
                   select stud;
        }
        public static IEnumerable<Student> ExtractStudentWithTwoMarks(this IEnumerable<Student> arrStudent, int num, int times)
        {
            Func<int, bool> intFunc = (x) => x == num;
            return from stud in arrStudent
                   where stud.Marks.Count(intFunc) == times
                   select stud;
        }
    }
}
