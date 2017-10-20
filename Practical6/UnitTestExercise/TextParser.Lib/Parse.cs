using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextParser.Lib
{
    /// <summary>
    /// This class is used to perform some simple text parsing functions using regex.
    /// </summary>
    public static class Parse
    {
        /// <summary>
        /// Extracts the vowels a,e,i,o,u from a string.
        /// </summary>
        public static string ExtractVowels(string text)
        {
            string vowels = @"[aeiou]";
            MatchCollection match = Regex.Matches(text, vowels, RegexOptions.IgnoreCase);

            StringBuilder sb = new StringBuilder();
            foreach (var m in match)
            {
                sb.Append(m + " ");
            }
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Extracts the conjunctions and,or,but,yet,for,so,nor from a string.
        /// </summary>
        public static string ExtractConjunctions(string text)
        {
            string conjunctions = @"and|or|but|yet|for|so|nor";
            MatchCollection match = Regex.Matches(text, conjunctions, RegexOptions.IgnoreCase);

            StringBuilder sb = new StringBuilder();
            foreach (var m in match)
            {
                sb.Append(m + " ");
            }
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Extracts all words which start with upper case from a string.
        /// </summary>
        public static string ExtractUpperCaseWords(string text)
        {
            string upperCaseRegex = @"[A-Z][a-z]+";
            MatchCollection match = Regex.Matches(text, upperCaseRegex);

            StringBuilder sb = new StringBuilder();
            foreach (var m in match)
            {
                sb.Append(m + " ");
            }
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Extracts all words which start with lower case from a string.
        /// </summary>
        public static string ExtractLowerCaseWords(string text)
        {
            string lowerCaseRegex = @"\b[a-z]+\b";
            MatchCollection match = Regex.Matches(text, lowerCaseRegex);

            StringBuilder sb = new StringBuilder();
            foreach (var m in match)
            {
                sb.Append(m + " ");
            }
            return sb.ToString().Trim();
        }
    }
}
