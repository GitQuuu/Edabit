using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Code
    {

        ///<summary>
        ///Difficulty: Medium
        ///</summary>

        // Format Number with Comma(s) Separating Thousands - https://edabit.com/challenge/GvGSPC9wiY4bS9AMg
        public static string FormatNum(int num)
        {
            return string.Format("{0:N0}", num);
        }

    }
}
