using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Edabit
{
    class workSheet
    {

        public static int differenceMaxMin(int[] arr)
        {
            int _varLowestValue = arr[0];
            int _varHighestValue;

            foreach (int element in arr)
            {
                if (element > _varLowestValue)
                {
                    _varLowestValue = element;
                }
            }

            return _varLowestValue;
        }
    }
}
