﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

namespace Edabit
{
    class Medium
    {
        /// <summary>
        /// Medium: Remove all consecutive exclamation or question marks
        /// </summary>
        /// <param name="phrase">Input string to analyze</param>
        /// <returns>A string without consecutive exclamation or question marks</returns>
        public static string NoYelling(string phrase)
        {
            char[] symbols = { '!', '?' };

            StringBuilder sb = new StringBuilder();
            if (phrase.Contains('!') || phrase.Contains('?'))
            {
                string[] words = phrase.Split(" ");

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].TrimEnd(symbols);
                    if (i < words.Length - 1)
                        sb.Append(words[i] + " ");
                    else
                    {
                        sb.Append(words[i]);
                        if (phrase.EndsWith('!'))
                            return sb.ToString() + "!";
                        else if (phrase.EndsWith('?'))
                            return sb.ToString() + "?";
                    }
                }

            }
            return phrase;
        }

        ///<summary>
        /// Method to print array to string
        /// </summary>
        public static string PrintIntArray(int[] otherMethods)
        {
            string ArrayToString = "";

            foreach (int element in otherMethods)
            {
                ArrayToString += element.ToString() + " ";
            }
            return $"{ArrayToString}";
        }
        /// <summary>
        /// same as above just for arguments of string[] instead of int[]
        /// </summary>    
        public static string PrintStringArray(string[] otherMethods)
        {
            string ArrayToString = "";

            foreach (string element in otherMethods)
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
            if (values.Length > 0)
            {
                int valueFromArray = values[0];
                int index = 0;

                foreach (int element in values)
                {

                    if (valueFromArray > element)
                    {
                        valueFromArray = element;
                    }
                }
                //    = Find the index number of elementValue
                index = Array.IndexOf(values, valueFromArray);
                // instantiating a int list = with values from the array
                List<int> newArrayList = new List<int>(values);
                // manipulating the list to remove the index that we got from line 235
                newArrayList.RemoveAt(index);

                return values = newArrayList.ToArray();
            }
            else
            {
                return values;
            }

        }

        ///<summary>
        ///Format Number with Comma(s) Separating Thousands - https://edabit.com/challenge/GvGSPC9wiY4bS9AMg
        ///</summary> 
        public static string FormatNum(int num)
        {   // 0 represents the 1st variabel N0 represents number of digits
            return string.Format("{0:N0}", num);
        }

        ///<summary>
        /// Medium : Remove All Special Characters from a String - https://edabit.com/challenge/SfZx7qzXheYQxtQbF
        ///</summary> 
        public static string RemoveSpecialCharacters(string str)
        {   // put desired value for which you dont want to replace in the brackets
            return Regex.Replace(str, "[^0-9A-Za-z _-]", "");
        }

        ///<summary>
        ///Basic E-Mail Validation - https://edabit.com/challenge/egy6LWExtnR6JkwBg
        ///</summary> 
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

                        if (str[index] == symbols[0])
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