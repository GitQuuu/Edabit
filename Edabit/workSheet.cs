using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Edabit
{
    class workSheet
    {

        public static string MonthName(int num)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
        }
    }
}
