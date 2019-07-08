using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class workSheet
    {

        public static bool EqualSlices(int total, int people, int each)
        {
            return people * each <= total ? true : false;    
        }
    }
}
