using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    static class StringUtilities
    {
        public static char[] CreateSortedCharArrayFromString(string s)
        {
            var charArray = s.ToCharArray();
            Array.Sort(charArray);

            return charArray;
        }

        public static Dictionary<char, int> CountCharsInString(string s, bool countSpaces)
        {
            var dictionary = new Dictionary<char, int>();

            // count all the chars in the first string
            foreach (char character in s.ToLower().ToCharArray())
            {
                if (!countSpaces && character == ' ')
                {
                    continue;
                }

                if (dictionary.ContainsKey(character))
                {
                    dictionary[character]++;
                }
                else
                {
                    dictionary.Add(character, 1);
                }
            }

            return dictionary;
        }
    }
}
