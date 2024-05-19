using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime birthDate) 
        {
            DateTime todaysDate = DateTime.Now;
            int yearDifference = todaysDate.Year - birthDate.Year;
            int monthDifference = todaysDate.Month - birthDate.Month;
            int dayDifference = todaysDate.Day - birthDate.Day;
            if( monthDifference < 0 || (monthDifference == 0 && dayDifference <0))
            {
                return yearDifference - 1 ;
            }
            else
            {
                return yearDifference ;
            }
        }
    }
}
