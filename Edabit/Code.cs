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

        public static bool IsPluralDepthMethod(string word)
        {
            return word.Substring(word.Length - 1, 1) == "s" ? true : false;
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

    }
}
