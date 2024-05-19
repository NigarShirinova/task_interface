﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    internal static class MathUtilities
    {
        public static bool IsPrime(this int number)
        {
            bool label = false;
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    label = true;
                    break;
                }

            }
            if (label) { return false; }
            return true;
        }
    }
}