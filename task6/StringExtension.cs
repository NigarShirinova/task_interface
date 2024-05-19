using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal static class StringExtension
    {
        public static bool IsPolindrom(this string word)
        {
            string reversedWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord = reversedWord + word[i];
            }
            if(reversedWord == word) 
            {
                return true;
            }
            return false;

        }
    }
}
