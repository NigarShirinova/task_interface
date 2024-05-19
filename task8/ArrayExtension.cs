using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal static class ArrayExtension
    {
        public static double CalculateAvarage(this int[] array) 
        {

            int sum = array.Sum();
            return sum / array.Length;
        }
    }
}
