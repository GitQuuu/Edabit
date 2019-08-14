﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Task
    {
        public static void NoYelling()
        {
            Console.WriteLine("Create a function that takes an character and string as arguments and returns the number of times the character is found in the string.");
        }
        public static void ReturnFourLetterString()
        {
            Console.WriteLine("Create a function that takes an array of strings. Return all words in the array that are exactly four letters.");
        }
        public static void EliminateOddNumbers()
        {
            Console.WriteLine("Create a function that takes an array of numbers and returns only the even values.");
        }
        public static void ValidZipCode()
        {
            Console.WriteLine("Zip codes consist of 5 consecutive digits. Given a string, write a function to determine whether the input is a valid zip code.");
        }
        public static void DisplayPhoneNumberCorrectly()
        {
            Console.WriteLine("Create a function that accepts a string and returns true if it's in the format of a proper phone number and false if it's not. Assume any number between 0-9 (in the appropriate spots) will produce a valid phone number. This is what a valid phone number looks like: (123) 456-7890");
        }
        public static void DisplayFormatPhoneNumber()
        {
            Console.WriteLine("Create a function that takes an array of 10 numbers (between 0 and 9) and returns a string of those numbers formatted as a phone number (e.g. (555) 555-5555).");
        }
        public static void DisplayCalCulateMean()
        {
            Console.WriteLine("Create a function that takes an array of numbers and returns the mean value.");
        }
        public static void DisplayDifferenceMaxMin()
        {
            Console.WriteLine("Create a function that takes an array and returns the difference between the smallest and biggest numbers.");
        }
        public static void DisplayAddUp()
        {
            Console.WriteLine("Create a function that takes a number as an argument. Add up all the numbers from 1 to the number you passed to the function. For example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 4 = 10.");
        }
        public static void DisplayDoubleLetters()
        {
            Console.WriteLine("Create a function that takes a word and returns true if the word has two consecutive identical letters.");
        }
        public static void DisplayTheMuseumOfIncrediblyDullThings()
        {
            Console.WriteLine("Create a function that takes an array of integers and removes the smallest value.");
        }
        public static void DisplayMonthName()
        {
            Console.WriteLine("Create a function that takes a number (from 1 to 12) and return its corresponding month name as a string.Months");
        }
        public static void DisplayStringComparison()
        {
            Console.WriteLine("Create a function that takes two strings and returns true if the first string ends with the second string; otherewise return false.");
        }
        public static void DisplayGetWordCount()
        {
            Console.WriteLine("Create a function that takes a string and returns the word count. The string will be a sentence.");
        }
        public static void DisplaySmallerStringNumber()
        {
            Console.WriteLine("Create a function that returns the smaller number.");
        }
        public static void DisplaySliceOfPie()
        {
            Console.WriteLine("Create a function that determines whether or not it's possible to split a pie fairly given these three parameters:");
        }
        public static void DisplayReturnLastElement()
        {
            Console.WriteLine("Create a function that accepts an array and returns the last item in the array. The array can contain any of JavaScript's five primitive data types.");
        }
        public static void DisplayDaysInMonth()
        {
            Console.WriteLine("Create a function that takes the month and year (as integers) and returns the number of days in that month.");
        }
        public static void DisplayMissingThirdAngle()
        {
            Console.WriteLine("Write a function that classifies the missing angle as either \"acute\", \"right\", or \"obtuse\" based on its degrees.");
            Console.WriteLine("An acute angle is one smaller than 90 degrees.");
            Console.WriteLine("A right angle is one that is exactly 90 degrees.");
            Console.WriteLine("An obtuse angle is one greater than 90 degrees (but smaller than 180 degrees).");

            Console.WriteLine("For example: MissingAngle(11, 20) should return \"obtuse\", since the missing angle would be 149 degrees, which makes it obtuse.\n");
        }
        public static void DisplayLargestNumberInArray()
        {
            Console.WriteLine("Create a function that takes an array of numbers. Return the largest number in the array.\n");
        }
        public static void DisplaySmallestNumberInArray()
        {
            Console.WriteLine("Create a function that takes an array of numbers and returns the smallest number in the set.");
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
            Console.WriteLine("Create a function that takes in a word and determines whether or not it is plural. A plural word is one that ends in \"s\".\n");
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
