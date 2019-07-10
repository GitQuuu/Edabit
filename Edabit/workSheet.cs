using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace Edabit
{
    class workSheet
    {

        public static double Mean(int[] arr)
        {
            double sum = arr.Sum();
            return Math.Round(sum / arr.Length, 2);
        }
    }
}
