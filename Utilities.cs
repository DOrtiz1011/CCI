using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    static class Utilities
    {
        public static char[] CreateSortedCharArrayFromString(string s)
        {
            var charArray = s.ToCharArray();
            Array.Sort(charArray);

            return charArray;
        }
    }
}
