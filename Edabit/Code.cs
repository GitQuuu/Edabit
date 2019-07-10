using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;


namespace Edabit
{
   
    class Code
    {
        // very easy
        ///<summary>very easy: 
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

        ///<summary>very easy: 
        /// return the number of days in month - https://edabit.com/challenge/TaWxNNHPHZmbMnBZx 
        ///</summary>  
        public static int Days(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }

        ///<summary>very easy: 
        /// Missing third angle - https://edabit.com/challenge/SZwKNfxC9JBsG99Gz
        ///</summary>
        public static string MissingAngle(int angle1, int angle2)
        {
            
            int maxDegree = 180;            

            if ((maxDegree - angle1 - angle2) < 90)
            {
                return  "acute";
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

        ///<summary>very easy: 
        /// return the last element in array - https://edabit.com/challenge/oMFuP2d4Qr53HG588
        ///</summary>  
        public static object GetLastItem(object[] arr)
        {

            return arr[arr.Length - 1];
        }

        /// <summary>very easy:
        /// Find the Largest Number in an Array - https://edabit.com/challenge/4huAhWBE7f3asEFAz
        /// </summary>
        public static int FindLargestNum(int[] arr)
        {
            int highestValue = 0;

            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] > highestValue)
                {
                    highestValue = arr[index];
                }
            }

            return highestValue;
        }

        ///<summary>
        /// very easy:
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

        ///<summary> very easy: 
        /// Check String for spaces - https://edabit.com/challenge/RhjB3ckgMXiW5xdTB
        ///</summary>  
        public static bool HasSpaces(string str)
        {
            return str.Contains(" ") ? true : false;
        }

        ///<summary>
        /// very easy:
        /// Slice of Pie , split the pie fairly?
        ///</summary>
        public static bool EqualSlices(int total, int people, int each)
        {
            return people * each <= total ? true : false;
        }

        //Easy
        ///<summary>easy:
        /// Remove the First and Last Characters - https://edabit.com/challenge/hjFH2T4Gay7m9ka2m
        ///</summary>     
        public static string RemoveFirstLast(string str)
        {   // The reason for this to be correct and apparently not 0 and Length-1 is to remember startindex, is the beginning of the string we want to keep 
            if (str.Length > 3)
            {
                str = str.Substring(1, str.Length - 2);
                return str;
            }
            else
            {
                return str;
            }
           
        }

        /// <summary>
        /// Easy:
        /// Create a function that returns the smaller number of strings - https://edabit.com/challenge/uBqpafqjoYNPuQ7Pr
        /// </summary>
        public static string SmallerNum(string n1, string n2)
        {

            return Convert.ToInt32(n1) < Convert.ToInt32(n2) ? n1 : n2;
        }

        /// <summary>
        /// Easy:
        /// Count number of words in string - https://edabit.com/challenge/DgQSXRDzh6QgfzDW2
        /// </summary>
        public static int CountWords(string str)
        {
            char[] whiteSpace = { ' ' };
            int wordCount = 1;

            foreach (char element in whiteSpace)
            {
                for (int index = 0; index < str.Length; index++)
                {
                    if (str[index] == element)
                    {
                        wordCount++;
                    }
                }
            }

            return wordCount;
        }

        ///<summary>
        ///Easy:
        /// Check if String Ending Matches Second String - https://edabit.com/challenge/7fpuK6rvSJz5amJiP
        ///</summary>
        public static bool CheckEnding(string str1, string str2)
        {

            return str1.EndsWith(str2) ? true : false;
        }

        /// <summary>
        /// Easy:
        /// Convert Number to Corresponding Month Name - https://edabit.com/challenge/uevxL5FNM77otyo9Z && https://stackoverflow.com/questions/6286868/convert-month-int-to-month-name 
        /// </summary>
        public static string MonthName(int num)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
        }


        //Medium
        ///<summary>
        /// Method to print array to string
        /// </summary>
        public static string PrintArray(int[] otherMethods)
        {
            string ArrayToString = "";
            Console.WriteLine(ArrayToString);
            foreach  (int element in otherMethods)
            {
                ArrayToString += element.ToString() + " ";
            }
            return $"{ArrayToString}";
        }

        ///<summary>
        /// Medium:
        /// The musem of incredibly dull things - https://edabit.com/challenge/dgHXtSrgyWbJ3cXvL - https://stackoverflow.com/questions/496896/how-to-delete-an-element-from-an-array-in-c-sharp
        ///</summary>
        public static int[] RemoveSmallest(int[] values)
        {
            if (values.Length == 0)
            {
                return values;
            }

            int valueFromArray = values[0]; 
            int index = 0;

           
            
                foreach (int element in values)
                {

                    if (valueFromArray > element)
                    {
                        valueFromArray = element;
                    }
                }

                index = Array.IndexOf(values, valueFromArray);

                List<int> newArrayList = new List<int>(values);
                newArrayList.RemoveAt(index);

                return values = newArrayList.ToArray();
            
         
        }

        // Format Number with Comma(s) Separating Thousands - https://edabit.com/challenge/GvGSPC9wiY4bS9AMg

        public static string FormatNum(int num)
        {   // 0 represents the 1st variabel N0 represents number of digits
            return string.Format("{0:N0}", num);
        }

        // Remove All Special Characters from a String - https://edabit.com/challenge/SfZx7qzXheYQxtQbF
        public static string RemoveSpecialCharacters(string str)
        {   // put desired value for which you dont want to replace in the brackets
            return Regex.Replace(str, "[^0-9A-Za-z _-]", "");
        }

        // Basic E-Mail Validation - https://edabit.com/challenge/egy6LWExtnR6JkwBg
        public static bool ValidateEmail(string str)
        {
            char[] symbols = { '@', '.' };
            int match = 0;
            int EmailPos = 0;
            int PeriodPos = 0;

            foreach (char element in symbols)
            {
                for (int index = 0; index < str.Length; index++)
                {
                    // without this the program will crash because we are out of our array boundaries
                    if (index - 1 >= 0)
                    {
                        if (str[index] == element && char.IsLetterOrDigit(str[index - 1]) && !char.IsPunctuation(str[index + 1]) && str.Contains(symbols[1]))
                        {
                            match++;
                        }

                        if (str[index] == symbols[0] )
                        {
                            EmailPos = index;                           
                        }
                        else if (str[index] == symbols[1])
                        {
                            PeriodPos = index;
                        }
           
                    }

                }
                if (match == 0)
                {
                    break;
                }
            }

            if (match >= 1 && EmailPos < PeriodPos)
            {
                Console.Write("Email valid");
                return true;
            }
            else
            {
                
                Console.Write("Email not valid");
                return false;
            }
        }

    }
}
