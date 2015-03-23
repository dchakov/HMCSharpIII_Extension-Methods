using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem17LongestString
{
    public class Longest
    {
        public static void Main()
        {
            //Problem 17. Longest string• Write a program to return the string with maximum length from an array of strings.
            //• Use LINQ.

            string[] array = new string[]
            { 
                "Nikolay Stoianov", 
                "Evtim Grigorov",
                "Asen Bandeleshki", 
                "Nik Popov", 
                "Temenujka Vladimirova",
                "Nikol Taneva"
            };
            Console.WriteLine(LongestString(array));
            Console.WriteLine(array.LongestString().ToArray().First());
            
        }
        public static string LongestString(string[] array)
        {
            int longest = array.Max(x => x.Length);
            var m = from str in array
                   where str.Length == longest
                   select str;
            return m.ToArray().First();
        }
    }
}
