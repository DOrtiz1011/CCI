using System;

namespace CrackingTheCodingInterview.Problems
{
    static class Chap1_ArraysAndStrings
    {
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
                var charArray = StringUtilities.CreateSortedCharArrayFromString(testString);

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

        public static bool Prob2_CheckPermutation(string string1, string string2)
        {
            var isPermutation = false;

            if (string1.Length == string2.Length)
            {
                var dictionary = StringUtilities.CountCharsInString(string1, true);

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

        public static string Prob3_Urlify(string testString)
        {
            var urlifiedString = default(string);
            var charArray = testString.ToCharArray();
            var numSpaces = 0;

            // count spaces
            foreach (var character in charArray)
            {
                if (character == ' ')
                {
                    numSpaces++;
                }
            }

            if (numSpaces == 0)
            {
                urlifiedString = testString;
            }
            else
            {
                var urlCharArray = new char[testString.Length + numSpaces * 2];
                var index = 0;

                foreach (var character in charArray)
                {
                    if (character == ' ')
                    {
                        // add %20
                        urlCharArray[index] = '%';
                        urlCharArray[index + 1] = '2';
                        urlCharArray[index + 2] = '0';
                        index += 3;
                    }
                    else
                    {
                        urlCharArray[index] = character;
                        index++;
                    }
                }

                urlifiedString = new string(urlCharArray);
            }

            return urlifiedString;
        }

        public static bool Prob4_PalindromePermutation(string testString)
        {
            var isPalindromePermutation = true;
            var dictionary = StringUtilities.CountCharsInString(testString, false);
            var numOdd = 0;

            foreach (var keyValuePair in dictionary)
            {
                if (keyValuePair.Value % 2 != 0)
                {
                    numOdd++;

                    if (numOdd > 1)
                    {
                        isPalindromePermutation = false;
                        break;
                    }
                }
            }

            return isPalindromePermutation;
        }

        public static bool Prob5_OneAway(string string1, string string2)
        {
            var isOneAway = false;

            if (Math.Abs(string1.Length - string2.Length) < 1)
            {

            }

            return isOneAway;
        }
    }
}
