using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public bool IsAPalindrome(string word)
        {
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word.ToLower()[i];
            }
            return reversed == word.ToLower();


        }
    }
}
