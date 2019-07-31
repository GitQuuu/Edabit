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
        public static int[] NoOdds(int[] arr)
        {
            if (arr.Length > 0)
            {
                List<int> newArrayList = new List<int>(arr);

                foreach (int element in arr)
                {
                    if (element % 2 != 1)
                    {
                        newArrayList.Remove(element);
                    }
                }
                return arr = newArrayList.ToArray();
            }
            else
            {
                return arr;
            }
        }
    }
}
