using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

namespace Edabit
{
    class WorkSheet
    {

        public static bool IsValidPhoneNumber(string str)
        {
            char[] formats = {'(',')','-',' '};
            
            if (str.Length == 14 && formats[0] == str[0] && formats[1] == str[4] && formats[2] == str[9] && formats[3] == str[5])
            {
                return true;
            }


            else
            {
                return false;
            }
        }

    }
}
