using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class workSheet
    {

        public static int CountWords(string str)
        {
            char[] whiteSpace = {' ' };
            int wordCount = 0;

            foreach (char element in whiteSpace)
            {
                for (int index = 0; index < str.Length; index++)
                {
                    if (str[index] == element)
                    {
                        wordCount++;
                    }
                }
            }

            return wordCount;
        }
    }
}
