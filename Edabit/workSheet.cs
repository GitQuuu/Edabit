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
            char[] symbols = { '!', '?' };
            
            StringBuilder sb = new StringBuilder();
            if (phrase.Contains('!') || phrase.Contains('?'))
            {
                string[] words = phrase.Split(" ");

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].TrimEnd(symbols);
                    if (i < words.Length-1)
                        sb.Append(words[i] + " ");
                    else
                    {
                        sb.Append(words[i]);
                        if (phrase.EndsWith('!'))
                            sb.Append('!');
                        else if (phrase.EndsWith('?'))
                            sb.Append('?');
                    }            
                }
                
            }
            return sb.ToString();
        }           
    }
}
