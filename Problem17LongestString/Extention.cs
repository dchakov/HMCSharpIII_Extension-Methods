using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17LongestString
{
    public static class Extention
    {
        public static IEnumerable<string> LongestString(this string[] array)
        {
            int longest = array.Max(x => x.Length);
            return from str in array
                   where str.Length == longest
                   select str;
        }
    }
}
