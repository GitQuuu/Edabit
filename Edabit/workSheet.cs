using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

namespace Edabit
{
    class WorkSheet
    {
        public static string NoYelling(string phrase)
        {
            if (phrase.Contains('!'))
            {
                for (int index = 0; index < phrase.Length; index++)
                {
                    if (phrase[index] == '!')
                    {
                        return phrase.Remove(0,phrase.Length);
                    }
                    else
                    {
                        return phrase;
                    }
                }
            }


            return phrase;
            
        }
    }
}
