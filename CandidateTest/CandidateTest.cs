using System;

namespace CandidateTest
{
    public static class TestFunctions
    {
        /// <summary>
        /// Function that takes 2 values and calculates the average of the 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Average value of 2 numbers</returns>
        public static double Average(int a, int b)
        {
            return a + b / 2;
        }

        /// <summary>
        /// Takes 2 string arrays returns 1 string array containing each name only once, in alphabetical order (remove duplicates).
        /// </summary>
        /// <param name="names1"></param>
        /// <param name="names2"></param>
        /// <returns>String[] containing unique names</returns>
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            return new string[0];
        }

        /// <summary>
        /// Takes an input phrase, reverses it, and fixes capital letters, eg "Correct horse battery stapler" becomes "Stapler battery horse correct"
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ReversePhrase(string input)
        {
            return "";
        }
    }
}
