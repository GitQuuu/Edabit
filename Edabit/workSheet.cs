using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Edabit
{
    class Worksheet
    {
       /*Wurst is the best. Create a function that takes a string and replaces every mention of any type of sausage with the German 
       word "Wurst," unless—of course—the sausage is already a type of German "Wurst" (i.e. "Bratwurst", see below), 
       then leave the sausage name unchanged. https://edabit.com/challenge/YxRSS8DEue6WNQqya */
       public static string WurstIsBetter(string str)
       {
            
            string[] stringArray;
            stringArray = str.Split(" ");
            string result = "";

            string[] sausages = { "Kielbasa", "Chorizo", "Moronga", "Salami", "Sausage", "Andouille", "Naem", "Merguez", "Gurka", "Snorkers", "Pepperoni" };

            foreach (string words in sausages)
            {
                for (int index = 0; index < stringArray.Length; index++)
                {
                    if (stringArray.Contains(words))
                    {

                        return result += str.Replace(words[index].ToString(), "wurst");
                    }
                }
               
               
                
            }

            return result;
       }
       
    }
    
}
