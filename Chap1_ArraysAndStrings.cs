using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    /// <summary>
    /// Chapter 1 Problems from Cracking the Coding Interview 6th Edition
    /// </summary>
    static class Chap1_ArraysAndStrings
    {
        /// <summary>
        /// Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
        /// </summary>
        /// <param name="testString"></param>
        /// <returns></returns>
        public static bool Prob1_IsUnique(string testString)
        {
            var isUnique = false;

            if (string.IsNullOrEmpty(testString))
            {
                isUnique = false;
            }
            else if (testString.Length == 1)
            {
                isUnique = true;
            }
            else
            {
                // create sorted char array
                var charArray = Utilities.CreateSortedCharArrayFromString(testString);

                for (var index = 0; index < charArray.Length - 1; index++)
                {
                    if (charArray[index] == charArray[index + 1])
                    {
                        isUnique = true;
                        break;
                    }
                }
            }

            return isUnique;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>Given two strings, write a method to decide if one is a permutation of the other.
        public static bool Prob2_CheckPermutation(string string1, string string2)
        {
            var isPermutation = false;

            if (string1.Length == string2.Length)
            {
                var dictionary = new Dictionary<char, int>();
                
                // count all the chars in the first string
                foreach (char character in string1.ToLower().ToCharArray())
                {
                    if (dictionary.ContainsKey(character))
                    {
                        dictionary[character]++;
                    }
                    else
                    {
                        dictionary.Add(character, 1);
                    }
                }

                // loop through the second string and remove the chars from the dictionary
                foreach (char character in string2.ToLower().ToCharArray())
                {
                    if (dictionary.ContainsKey(character))
                    {
                        dictionary[character]--;

                        if (dictionary[character] == 0)
                        {
                            dictionary.Remove(character);
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (dictionary.Count == 0)
                {
                    isPermutation = true;
                }
            }

            return isPermutation;
        }
    }
}
