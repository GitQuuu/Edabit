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
        //Create a function that takes a string as an argument and converts the first character of each word to uppercase. Return the newly formatted string.
        public static string MakeTitle(string str)
        {
            string[] wordsArray;
            string result = "";
            
            wordsArray = str.Split(" ");

            if (str.Length < 0)
            {
                return "No input";
            }
            else
            {
                foreach (string word in wordsArray)
                {
                    for (int index = 0; index < word.Length; index++)
                    {
                        if (index < 1)
                        {
                            result += word[0].ToString().ToUpper();
                        }
                        else
                        {
                            result += word[index];
                        }
                    }
                    result += " ";
                }

            }

            return result.TrimEnd(' ');
            
        }

    }
    
}
