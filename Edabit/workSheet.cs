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
            stringArray = str.Split(' ');

            string[] sausages = { "sausage","Sausage","kielbasa","Kielbasa","chorizo","Chorizo", "moronga","Moronga","salami","Salami","andouille","Andouille","naem","Naem","merguez","Merguez","gurka","Gurka","snorkers","Snorkers","pepperoni","Pepperoni" };

            foreach (string words in stringArray)
            {
                foreach (string sausage in sausages)
                {
                    if (words.Contains(sausage))
                    {
                        str = str.Replace(sausage, "Wurst");
                    }
                }
            }

            return str;
        }

    }

}
