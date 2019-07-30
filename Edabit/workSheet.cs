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

        public static bool IsValid(string zip)
        {
            if (zip.Length == 5)
            {
                foreach (char element in zip)
                {
                    if (!char.IsDigit(element))
                    {
                        return false;
                    }                  
                }
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
