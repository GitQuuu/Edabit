using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Edabit
{
    class workSheet
    {

        public static bool DoubleLetters(string word)
        {
            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] == word[index + 1] && word[index] == word[index + 2])
                {
                    return true;
                }         
            }
            return false;
        }
    }
}
