using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Task
    {
        public static void DisplayLargestNumberInArray()
        {
            Console.WriteLine("Create a function that takes an array of numbers. Return the largest number in the array.");
        }
        public static void DisplayCheckStringForSpaces()
        {
            Console.WriteLine("Create a function that returns true if a string contains any spaces.");
        }
        public static void DisplayFirstAndLastCharacter()
        {
            Console.WriteLine("Create a function that removes the first and last characters from a string.");
        }
        public static void DisplaySingularOrPlural()
        {
            Console.WriteLine("Create a function that takes in a word and determines whether or not it is plural. A plural word is one that ends in \"s\".");
        }

        public static void DisplayRemoveSpecialCharacters()
        {
            Console.WriteLine("Create a function that takes a string, removes all \"special\" characters (e.g. ! @ # $ % ^ & \\ *) and returns the new string. The only non-alphanumeric characters allowed are dashes -, underscores _ and spaces.");
        }

        public static void DisplayValidateEmailTask()
        {
            Console.WriteLine("\nCreate a function that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.");         
            Console.WriteLine("The string must contain an @ character.");
            Console.WriteLine("The string must contain a . character.");
            Console.WriteLine("The @ must have at least one character in front of it.");
            Console.WriteLine("The . and the @ must be in the appropriate places.");
            Console.WriteLine("The email cannot end with .");
            
        }

        public static void PrintLine(int length)
        {
            Console.WriteLine(new string('#',length));
        }
    }
}
