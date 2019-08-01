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
        public static string[] IsFourLetters(string[] arr)
        {
            List<string> returnFourLetters = new List<string>(arr);

            foreach (string element in arr)
            {
                if (element.Length == 4)
                {
                    returnFourLetters.Add(element);
                }
            }

            return returnFourLetters.ToArray();
        }
    }
}
