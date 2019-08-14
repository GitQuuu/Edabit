using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

namespace Edabit
{
    class Very_Easy
    {
        ///<summary> 
        /// Is the Word Singular or Plural? https://edabit.com/challenge/virMEraL59KKGQdDv  
        ///</summary>         
        public static bool IsPlural(string word)
        {
            if (word.EndsWith("s"))
            {
                Console.Write("is plural");
                return true;
            }
            else
            {
                Console.WriteLine("non plural");
                return false;
            }
        }
        public static bool IsPluralInDepth(string word)
        {   // does the same as above just a more in depth method
            return word.Substring(word.Length - 1, 1) == "s" ? true : false;
        }

        ///<summary> 
        /// return the number of days in month - https://edabit.com/challenge/TaWxNNHPHZmbMnBZx 
        ///</summary>  
        public static int Days(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }

        ///<summary> 
        /// Missing third angle - https://edabit.com/challenge/SZwKNfxC9JBsG99Gz
        ///</summary>
        public static string MissingAngle(int angle1, int angle2)
        {

            int maxDegree = 180;

            if ((maxDegree - angle1 - angle2) < 90)
            {
                return "acute";
            }
            else if ((maxDegree - angle1 - angle2) == 90)
            {
                return "right";
            }
            else
            {
                return "obtuse";
            }

        }

        ///<summary>
        /// return the last element in array - https://edabit.com/challenge/oMFuP2d4Qr53HG588
        ///</summary>  
        public static object GetLastItem(object[] arr)
        {

            return arr[arr.Length - 1];
        }

        /// <summary>
        /// Find the Largest Number in an Array - https://edabit.com/challenge/4huAhWBE7f3asEFAz
        /// </summary>
        public static int FindLargestNum(int[] arr)
        {
            int highestValue = arr[0];

            for (int index = 0; index < arr.Length; index++)
            {
                if (highestValue < arr[index])
                {
                    highestValue = arr[index];
                }
            }

            return highestValue;
        }

        ///<summary>
        /// Find the Smallest Number in an Array
        ///</summary>
        public static double FindSmallestNum(double[] arr)
        {
            double lowestNum = int.MaxValue;

            for (int index = 0; index < arr.Length; index++)
            {
                if (lowestNum > arr[index])
                {
                    lowestNum = arr[index];
                }
            }
            return lowestNum;
        }

        ///<summary>
        /// Check String for spaces - https://edabit.com/challenge/RhjB3ckgMXiW5xdTB
        ///</summary>  
        public static bool HasSpaces(string str)
        {
            return str.Contains(" ") ? true : false;
        }

        ///<summary>
        /// Slice of Pie , split the pie fairly?
        ///</summary>
        public static bool EqualSlices(int total, int people, int each)
        {
            return people * each <= total ? true : false;
        }
    }
}
