using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1StringBuilderSubstring
{
    class MainMethod
    {
        static void Main()
        {
            StringBuilder helloString = new StringBuilder("Hello, Extension Methods!");
            Console.WriteLine(helloString.Substring(0, 6));
        }
    }
}
