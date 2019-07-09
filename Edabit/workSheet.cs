using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class workSheet
    {

        public static bool CheckEnding(string str1, string str2)
        {

            return str1.EndsWith(str2) ? true : false;
        }
    }
}
