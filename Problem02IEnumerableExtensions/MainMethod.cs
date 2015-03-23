using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem02IEnumerableExtensions
{
    class MainMethod
    {
        static void Main()
        {
            IEnumerable<int> test = new List<int>(){-2,1,3,4,2};
            IEnumerable<double> test1 = new List<double>() { 1.2, 2.3, 4.3,0.3 };
            Console.WriteLine(test.SumOfCollection());
            Console.WriteLine(test1.SumOfCollection());
            Console.WriteLine(test.ProductOfCollection());
            Console.WriteLine(test1.ProductOfCollection());
            Console.WriteLine(test.MinOfCollection());
            Console.WriteLine(test.MaxOfCollection());
            Console.WriteLine(test1.MinOfCollection());
            Console.WriteLine(test1.MaxOfCollection());
            Console.WriteLine(test.Average());
            Console.WriteLine(test1.Average());
            Console.WriteLine(test.AverageOfCollection());
            Console.WriteLine(test1.AverageOfCollection());
            
        }
    }
}
