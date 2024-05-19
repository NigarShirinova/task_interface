using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal static class StringCapitalizeExtension
    {
        public static string GetCapitalize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
            
        }
    }
}
