using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace Edabit
{
    class WorkSheet
    {

        public static string FormatPhoneNumber(int[] numbers)
        {
            string _varPhoneFormat = "";
            if (numbers.Length > 0)
            {
                foreach (int element in numbers)
                {
                    _varPhoneFormat += element;
                }             
            }

            _varPhoneFormat = _varPhoneFormat.Insert(0, "(");
            _varPhoneFormat = _varPhoneFormat.Insert(4, ") ");
            _varPhoneFormat = _varPhoneFormat.Insert(9, "-");

            return _varPhoneFormat;
        }

    }
}
