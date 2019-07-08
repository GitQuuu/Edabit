using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class workSheet
    {

        public static double FindSmallestNum(double[] arr)
        {
            double lowestNum = arr[0];

            foreach  (double element in arr)
            {
                if (element < lowestNum)
                {
                    lowestNum = element;
                }
            }
            return lowestNum;
        }
    }
}
