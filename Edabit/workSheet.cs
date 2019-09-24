using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;

namespace Edabit
{
    class Worksheet
    {
        /*Har en string af tal uden mellemrum og tak alle uligtal mellem 0 og 9 or skriv dem ud som bogstaver */
        
        public static string EmilTask(string numbers)
        {
            string newString = "";
            string[] array ={};
            

            for (int i = 0; i < numbers.Length; i++)
            {
                newString += numbers[i]+" ";
                array = newString.Split(" ").ToArray();
            }



            return newString;
        }
    }

}
