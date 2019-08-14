using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

namespace Edabit
{
    class Easy
    {
        ///<summary>
        /// return the four letter strings - https://edabit.com/challenge/W4x4o2M7ny6Cqkfhn
        /// </summary>
        public static string[] IsFourLetters(string[] arr)
        {
            List<string> returnFourLetters = new List<string>(arr);

            foreach (string element in arr)
            {
                if (element.Length != 4)
                {
                    returnFourLetters.Remove(element);
                }
            }

            return returnFourLetters.ToArray();
        }

        ///<summary>
        /// Eliminate odd numbers within an array - https://edabit.com/challenge/HkKNhhdfEGwxm9Fq6
        /// </summary>
        public static int[] NoOdds(int[] arr)
        {
            if (arr.Length > 0)
            {
                List<int> newArrayList = new List<int>(arr);

                foreach (int element in arr)
                {
                    if (element % 2 != 0)
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

        ///<summary>
        /// Valid zip Code
        ///</summary>
        public static bool IsValid(string zip)
        {
            if (zip.Length == 5)
            {
                foreach (char element in zip)
                {
                    if (!char.IsDigit(element))
                    {
                        return false;
                    }
                }
                return true;

            }
            else
            {
                return false;
            }
        }

        ///<summary>
        /// Is the phone Number formatted correctly
        ///</summary>
        public static bool IsValidPhoneNumber(string str)
        {
            char[] formats = { '(', ')', '-', ' ' };

            if (str.Length == 14 && formats[0] == str[0] && formats[1] == str[4] && formats[2] == str[9] && formats[3] == str[5])
            {
                return true;
            }


            else
            {
                return false;
            }
        }

        ///<summary>
        /// Phone Number Formatting
        ///</summary>
        public static string FormatPhoneNumber(int[] numbers)
        {
            string _varPhoneFormat = "";
            if (numbers.Length > 0)
            {
                foreach (int element in numbers)
                {
                    _varPhoneFormat += element;
                }
            }

            _varPhoneFormat = _varPhoneFormat.Insert(0, "(");
            _varPhoneFormat = _varPhoneFormat.Insert(4, ") ");
            _varPhoneFormat = _varPhoneFormat.Insert(9, "-");

            return _varPhoneFormat;
        }

        /// <summary>
        /// Calculate the Mean
        /// </summary>
        public static double Mean(int[] arr)
        {
            double sum = arr.Sum();
            return Math.Round(sum / arr.Length, 2);
        }

        /// <summary>
        /// Difference of Max and Min Numbers in Array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int differenceMaxMin(int[] arr)
        {
            int _varLowestValue = arr[0];
            int _varHighestValue = arr[0];

            foreach (int element in arr)
            {
                if (_varLowestValue > element)
                {
                    _varLowestValue = element;
                }

                if (_varHighestValue < element)
                {
                    _varHighestValue = element;
                }
            }



            return _varHighestValue - _varLowestValue;
        }

        ///<summary>
        /// Add up all the numbers from 1 to the number you passed to the function
        /// </summary>
        public static int AddUp(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i < num)
                {
                    sum += +i;
                }
            }
            return sum + num;
        }

        ///<summary>
        /// Create a function that takes a word and returns true if the word has two consecutive identical letters. - https://edabit.com/challenge/ugg9ZK7xY5vk5qJXr
        /// </summary>
        public static bool DoubleLetters(string word)
        {
            for (int index = 0; index < word.Length - 2; index++)
            {
                if (word[index] == word[index + 1])
                {
                    return true;
                }
            }
            return false;
        }

        ///<summary>
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
        /// Create a function that returns the smaller number of strings - https://edabit.com/challenge/uBqpafqjoYNPuQ7Pr
        /// </summary>
        public static string SmallerNum(string n1, string n2)
        {

            return Convert.ToInt32(n1) < Convert.ToInt32(n2) ? n1 : n2;
        }

        /// <summary>
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
        /// Check if String Ending Matches Second String - https://edabit.com/challenge/7fpuK6rvSJz5amJiP
        ///</summary>
        public static bool CheckEnding(string str1, string str2)
        {

            return str1.EndsWith(str2) ? true : false;
        }

        /// <summary>
        /// Convert Number to Corresponding Month Name - https://edabit.com/challenge/uevxL5FNM77otyo9Z - https://stackoverflow.com/questions/6286868/convert-month-int-to-month-name 
        /// </summary>
        public static string MonthName(int num)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
        }
    }
}
