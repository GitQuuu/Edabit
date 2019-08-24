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
        //Write a function that takes a string of one or more words as an argument and returns the same string, but with all five or more letter words reversed.Strings passed in will consist of only letters and spaces.
        //Spaces will be included only when more than one word is present.Examples
        public static string Reverse(string str)
        {
            string[] wordsArray;
            wordsArray = str.Split(" ");
            string result = "";
            
            foreach (string words in wordsArray)
            {
                if (words.Length < 5)
                    result += words;
                else
                    for (int index = words.Length - 1; index >= 0; index--)
                    {
                        result += words[index];
                    }

                result += " ";
            }

            return $"{result}";
        }
    }
    
}
