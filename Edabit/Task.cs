using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Task
    {
        public static void DisplayValidateEmailTask()
        {
            Console.WriteLine("\nCreate a function that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.");         
            Console.WriteLine("The string must contain an @ character.");
            Console.WriteLine("The string must contain a . character.");
            Console.WriteLine("The @ must have at least one character in front of it.");
            Console.WriteLine("The . and the @ must be in the appropriate places.");
            
        }

        public static void PrintLine(int length)
        {
            Console.WriteLine(new string('#',length));
        }
    }
}
