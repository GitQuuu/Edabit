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
       /*Wurst is the best. Create a function that takes a string and replaces every mention of any type of sausage with the German 
       word "Wurst," unless—of course—the sausage is already a type of German "Wurst" (i.e. "Bratwurst", see below), 
       then leave the sausage name unchanged. https://edabit.com/challenge/YxRSS8DEue6WNQqya */
       public static string WurstIsBetter(string str)
       {
            string[] sausages = { "Kielbasa", "Chorizo", "Moronga", "Salami", "Sausage", "Andouille", "Naem", "Merguez", "Gurka", "Snorkers", "Pepperoni" };
            string[] stringArray;
            stringArray = str.Split(" ");
            string result = "";

            foreach (string words in sausages)
            {
                if (stringArray.Contains(words))
                {
                    result += words.Replace(words, "Wurst ");

                }
                else
                {
                    result += stringArray.ToString();
                }         
            }

            return result;
       }
       
    }
    
}
