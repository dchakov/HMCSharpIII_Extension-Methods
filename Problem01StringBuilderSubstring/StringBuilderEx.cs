//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1StringBuilderSubstring
{
    public static class StringBuilderExtention
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int lenght)
        {
            StringBuilder result = new StringBuilder(lenght);
            if (index<0 || index > str.Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (lenght < 0)
            {
                throw new ArgumentException("Lenght cannot be negative number"); 
            }
            for (int i = index; i < index + lenght; i++)
            {
                result.Append(str[i].ToString());
            }
            return result;
        }
    }
}
