﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    internal static class StringReverseExtension
    {
        public static string ReverseString(this string str)
        {
            string reversedStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }
            return reversedStr;
        }
    }
}
