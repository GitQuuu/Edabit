using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

namespace Edabit
{
    class Worksheet
    {
        //Create a function that takes a string as its argument and returns the string in reversed order.
        public static string Reverse(string str)
        {
           
           char[] stringArray;
           string arrayToString = "";

           stringArray = str.ToCharArray();

           Array.Reverse(stringArray);

            foreach (char element in stringArray)
            {
                arrayToString += element.ToString();
            }

            return $"{arrayToString}";
            
        }
    }
}
