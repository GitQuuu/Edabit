using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Edabit
{
   
    class Code
    {

        ///<summary> Difficulty: very easy
        ///</summary>

        // Is the Word Singular or Plural? https://edabit.com/challenge/virMEraL59KKGQdDv
        public static bool IsPlural(string word)
        {
            if (word.EndsWith("s"))
            {
                Console.WriteLine("is plural");
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

        ///<summary> Difficulty: easy
        ///</summary>

        // Remove the First and Last Characters - https://edabit.com/challenge/hjFH2T4Gay7m9ka2m
        public static string RemoveFirstLast(string str)
        {   // The reason for this to be correct and apparently not 0 and Length-1 is because quotation marks is part of the string array on index 0 and Length-1
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

        ///<summary>
        ///Difficulty: Medium
        ///</summary>

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
