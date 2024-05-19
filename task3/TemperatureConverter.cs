using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal static class TemperatureConverter
    {
        public static int Degree { get; set; }

        public static double CelsiusToFahrenheit(int degree)
        {
            return degree*1.8 + 32;
        }

        public static double FaranheitToCelsius(int degree)
        {
            return degree*5/9 + 32;
        }
    }
}
