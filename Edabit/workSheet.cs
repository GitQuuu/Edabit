using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Xml;

namespace Edabit
{
    class Worksheet
    {
        /*Har en string af tal uden mellemrum og tak alle uligtal mellem 0 og 9 or skriv dem ud som bogstaver */
        
        public static string EmilTask(string numbers)
        {
            string oddNumbers = "";
            string[] oddArray = { };
            string oddNumbersToText = "";
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 1)
                {
                    oddNumbers += numbers[i] +" ";
                    oddArray = oddNumbers.Split(" ").ToArray();
                }
            }


            for (int index = 0; index < oddArray.Length-0; index++)
            {
                switch (int.Parse(oddArray[index]))
                {
                    case 9:
                        oddNumbersToText += "Nine ";
                        break;
                    case 7:
                        oddNumbersToText += "Seven ";
                        break;
                    case 5:
                        oddNumbersToText += "Five ";
                        break;
                    case 3:
                        oddNumbersToText += "Three ";
                        break;
                    case 1:
                        oddNumbersToText += "One ";
                        break;
                }
            }

            return oddNumbersToText;
        }
    }

}
