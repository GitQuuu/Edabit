using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Edabit
{
    class workSheet
    {

        public static int[] RemoveSmallest(int[] values)
        {
            Array.Sort(values);
            return values;
        }
    }
}
