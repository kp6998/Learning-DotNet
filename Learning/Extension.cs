using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal static class Extension
    {
        public static int GetLetterCount(this string str)
        {
            return str.Length;
        }
        public static string ShortenText(this string str, int count)
        {
            if (str.Length < count)
                return str;
            if (count < 0)
                return "Enter postive number";
            return str.Substring(0, count);
        }
    }
}
