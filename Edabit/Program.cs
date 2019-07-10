using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A run through edabit challenges\n");

            Task.PrintLine(150);
            Task.DisplayAddUp();
            Console.WriteLine("\nAdd up the Numbers from a Single Number \"13\" :" + Code.AddUp(13));

            Task.PrintLine(150);
            Task.DisplayDoubleLetters();
            Console.WriteLine("\nReturn true if the word have two consecutive identical letters and vice versa \"teest : " + Code.DoubleLetters("Teest")); 

            Task.PrintLine(150);
            Task.DisplayTheMuseumOfIncrediblyDullThings();
            Console.WriteLine("remove lowest value in array { 11, 3, 5, 12, 423 } : " + Code.PrintArray(Code.RemoveSmallest(new int[] { 11, 3, 5, 12, 423 }))); 
            
            Task.PrintLine(150);
            Task.DisplayMonthName();
            Console.WriteLine("Display no. in month 5:                " + Code.MonthName(5));

            Task.PrintLine(150);
            Task.DisplayGetWordCount();
            Console.WriteLine("\nCount how many words in this string: " + Code.CountWords("Count how many words in this string"));

            Task.PrintLine(150);
            Task.DisplaySmallerStringNumber();
            Console.WriteLine("\n100 , 200 :                       " + Code.SmallerNum("100","200"));

            Task.PrintLine(150);
            Task.DisplaySliceOfPie();
            Console.WriteLine("\nSlices 11, Recipients 5, each 2 : " + Code.EqualSlices(11,5,2));

            Task.PrintLine(150);
            Task.DisplayReturnLastElement();
            Console.WriteLine("\n\"Cat\", \"Dog\", \"Duck\" :      " +  Code.GetLastItem(new object[] { "Cat", "Dog", "Duck" }));

            Task.PrintLine(150);
            Task.DisplaySmallestNumberInArray();
            Console.WriteLine("\nFind the smallest number in array :" + Code.FindSmallestNum(new double[] { 30, 1, 2, 3, 4, 5 }));

            Task.PrintLine(150);
            Task.DisplayLargestNumberInArray();
            Console.WriteLine("Max value in {1,3,5,87} :  " + Code.FindLargestNum(new int[] { 1, 3, 5, 87 }));

            Task.PrintLine(150);
            Task.DisplayDaysInMonth();
            Console.WriteLine("\nDays in month :           " + Code.Days(2,2018));

            Task.PrintLine(150);
            Task.DisplayMissingThirdAngle();
            Console.WriteLine($"Missing angle is :        " + Code.MissingAngle(135, 11));
            
            Task.PrintLine(150);
            Task.DisplayCheckStringForSpaces();
            Console.WriteLine("\nCheckThisStringForSpaces : " + Code.HasSpaces("CheckThisStringForSpaces"));
            
            Task.PrintLine(150);
            Task.DisplayFirstAndLastCharacter();
            Console.WriteLine("\nHello Edabit :             " + Code.RemoveFirstLast("Hello Edabit")); 
            
            Task.PrintLine(150);
            Task.DisplayRemoveSpecialCharacters();
            Console.WriteLine("\nRemove%Specials£_- :       " + Code.RemoveSpecialCharacters("Remove%Specials£_-"));            
            
            Task.PrintLine(150);
            Task.DisplaySingularOrPlural();
            Console.WriteLine($"\nTrees :                    " + Code.IsPlural("Trees"));            
            
            Task.PrintLine(150);
            Task.DisplayValidateEmailTask();
            Console.Write("\n@edabit.com :              ");                 Code.ValidateEmail("@edabit.com");
            Console.Write("\n@edabit :                  ");                 Code.ValidateEmail("@edabit");
            Console.Write("\nmatt@edabit.com :          ");                 Code.ValidateEmail("matt@edabit.com");
            Console.Write("\n :                         ");                 Code.ValidateEmail("");
            Console.Write("\nhello.gmail@com :          ");                 Code.ValidateEmail("hello.gmail@com");
            Console.Write("\nbill.gates@microsoft.com : ");                 Code.ValidateEmail("bill.gates@microsoft.com");
            Console.Write("\nhello@email :              ");                 Code.ValidateEmail("hello@email");
            Console.Write("\n%^%$#%^% :                 ");                 Code.ValidateEmail("%^%$#%^%");
            Console.Write("\nwww.email.com :            ");                 Code.ValidateEmail("www.email.com");
            Console.Write("\nemail :                    ");                 Code.ValidateEmail("email");
            Console.WriteLine("");

            






            Console.ReadLine();
        }
    }
}
