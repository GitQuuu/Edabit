using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class workSheet
    {

        public static int Days(int month, int year)
        {
           return DateTime.DaysInMonth(year, month);
        }
    }
}
