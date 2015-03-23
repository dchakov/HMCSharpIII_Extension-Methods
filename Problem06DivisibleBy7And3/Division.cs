//Problem 6. Divisible by 7 and 3• Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem06DivisibleBy7And3
{
    class Division
    {
        static void Main()
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 21, 9, 14, 63 };

            var divisable1 = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
            Console.WriteLine(string.Join(" ", divisable1));

            Console.WriteLine();
            var divisable =
                from num in numbers
                where num % 3 == 0 && num % 7 == 0
                select num;
            foreach (var item in divisable)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
