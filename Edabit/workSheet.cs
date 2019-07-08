using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class workSheet
    {

        public static string smallerNum(string n1, string n2)
        {
            return Convert.ToInt32(n1) < Convert.ToInt32(n2) ? n1 : n2;
        }
    }
}
