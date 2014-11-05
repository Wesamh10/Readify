using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyServiceApplication.Managers
{
    public class WordsManager
    {
        public string ReverseWords(string s)
        {
            // throw exception if input is null
            if (s == null)
                throw new ArgumentNullException("s");

            // return empty string if input is empty
            if (string.IsNullOrEmpty(s)) return s;

            // split string on spaces, reverse each word alone. then aggregate on space.
            var str = s.Split(' ').Aggregate("", (current, ss) => current + (ReverseOneWord(ss) + ' '));
            return str.Substring(0, str.Length - 1);

        }

        // a helper function to reverse one word.
        private string ReverseOneWord(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}