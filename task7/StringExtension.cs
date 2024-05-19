using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal static class StringExtension
    {
        public static bool IsTrue(this string str)
        {
           string strCapitalize = str.ToUpper();
           if (strCapitalize == str && str.Length == 7) 
            { 
            return true;
            }
           return false;
        }
    }
}
