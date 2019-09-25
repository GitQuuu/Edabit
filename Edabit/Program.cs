using System;
using System.Text;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A run through edabit challenges\n");

           //Console.WriteLine(Worksheet.EmilTask2("Skole"));

            Task.PrintLine(150);
            Task.EmilTask1();
            Console.WriteLine("\n987651651                                            " + Medium.EmilTask1("987651651"));

            Task.PrintLine(150);
            Task.WurstIsBetter();
            Console.WriteLine("\nIl n’arrête pas de faire l’Wurst and Chorizo       " + Medium.WurstIsBetter("Il n’arrête pas de faire l’Wurst and Chorizo"));

            Task.PrintLine(150);
            Task.ReverseSome();
            Console.WriteLine("\nJeg hedder Nicoline Kops Le femte                  " + Medium.ReverseSome("Jeg hedder Nicoline Kops Le femte"));

            Task.PrintLine(150);
            Task.MakeTitle();
            Console.WriteLine("\nMake each words first letter uppercase             " + Medium.MakeTitle("Make each words first letter uppercase"));

            Task.PrintLine(150);
            Task.Reverse();
            Console.WriteLine("\nHej jeg hedder                                     " + Medium.ReverseAll("Hej jeg hedder"));

            Task.PrintLine(150);
            Task.NoYelling();
            Console.WriteLine("\nNo??? ??Yelling??? Emil??                           " + Medium.NoYelling("No??? ??Yelling??? Emil??"));

            Task.PrintLine(150);
            Task.ReturnFourLetterString();
            Console.WriteLine("\n{\"Nicoline\",\"Clara\",\"Luca\",\"Quan\"} :       " + Medium.PrintArray(Easy.IsFourLetters(new string[] { "Nicoline", "Clara", "Luca", "Quan" })));

            Task.PrintLine(150);
            Task.EliminateOddNumbers();
            Console.WriteLine("\nRemove odds number {1,2,3,4,5,6} :                 " + Medium.PrintArray(Easy.NoOdds(new int[] { 1, 2, 3, 4, 5, 6 })));

            Task.PrintLine(150);
            Task.ValidZipCode();
            Console.WriteLine("\n84516 :                                            " + Easy.IsValid("84516"));

            Task.PrintLine(150);
            Task.DisplayPhoneNumberCorrectly();
            Console.WriteLine("\nPhone no:9845641654 :                              " + Easy.IsValidPhoneNumber("9845641654"));

            Task.PrintLine(150);
            Task.DisplayFormatPhoneNumber();
            Console.WriteLine("\n{ 6, 0, 1, 7, 7, 5, 1, 6,9,2 } :                   " + Easy.FormatPhoneNumber(new int[] { 6, 0, 1, 7, 7, 5, 1, 6, 9, 2 }));

            Task.PrintLine(150);
            Task.DisplayCalCulateMean();
            Console.WriteLine("\nCalculate the mean of { 1,2,5,3,6} :               " + Easy.Mean(new int[] { 1, 2, 5, 3, 6 }));

            Task.PrintLine(150);
            Task.DisplayDifferenceMaxMin();
            Console.WriteLine("\n[10, 5, 6, 8, 15,-5} :                             " + Easy.differenceMaxMin(new int[] { 10, 5, 6, 8, 15, -5 }));

            Task.PrintLine(150);
            Task.DisplayAddUp();
            Console.WriteLine("\nAdd up the Numbers from a Single Number \"13\" :   " + Easy.AddUp(13));

            Task.PrintLine(150);
            Task.DisplayDoubleLetters();
            Console.WriteLine("\nReturn true if the word have two consecutive identical letters and vice versa \"teest : " + Easy.DoubleLetters("Teest"));

            Task.PrintLine(150);
            Task.DisplayTheMuseumOfIncrediblyDullThings();
            Console.WriteLine("remove lowest value in array { 11, 3, 5, 12, 423 } : " + Medium.PrintArray(Medium.RemoveSmallest(new int[] { 11, 3, 5, 12, 423 })));

            Task.PrintLine(150);
            Task.DisplayMonthName();
            Console.WriteLine("\nDisplay no. in month 5:                            " + Easy.MonthName(5));

            Task.PrintLine(150);
            Task.DisplayGetWordCount();
            Console.WriteLine("\nCount how many words in this string:               " + Easy.CountWords("Count how many words in this string"));

            Task.PrintLine(150);
            Task.DisplaySmallerStringNumber();
            Console.WriteLine("\n100 , 200 :                                        " + Easy.SmallerNum("100", "200"));

            Task.PrintLine(150);
            Task.DisplaySliceOfPie();
            Console.WriteLine("\nSlices 11, Recipients 5, each 2 :                  " + Very_Easy.EqualSlices(11, 5, 2));

            Task.PrintLine(150);
            Task.DisplayReturnLastElement();
            Console.WriteLine("\n\"Cat\", \"Dog\", \"Duck\" :                       " + Very_Easy.GetLastItem(new object[] { "Cat", "Dog", "Duck" }));

            Task.PrintLine(150);
            Task.DisplaySmallestNumberInArray();
            Console.WriteLine("\nFind the smallest number in array :                " + Very_Easy.FindSmallestNum(new double[] { 30, 1, 2, 3, 4, 5 }));

            Task.PrintLine(150);
            Task.DisplayLargestNumberInArray();
            Console.WriteLine("Max value in {1,3,5,87} :                            " + Very_Easy.FindLargestNum(new int[] { 1, 3, 5, 87 }));

            Task.PrintLine(150);
            Task.DisplayDaysInMonth();
            Console.WriteLine("\nDays in month :                                    " + Very_Easy.Days(2, 2018));

            Task.PrintLine(150);
            Task.DisplayMissingThirdAngle();
            Console.WriteLine($"Missing angle is :                                  " + Very_Easy.MissingAngle(135, 11));

            Task.PrintLine(150);
            Task.DisplayCheckStringForSpaces();
            Console.WriteLine("\nCheckThisStringForSpaces :                         " + Very_Easy.HasSpaces("CheckThisStringForSpaces"));

            Task.PrintLine(150);
            Task.DisplayFirstAndLastCharacter();
            Console.WriteLine("\nHello Edabit :                                     " + Easy.RemoveFirstLast("Hello Edabit"));

            Task.PrintLine(150);
            Task.DisplayRemoveSpecialCharacters();
            Console.WriteLine("\nRemove%Specials£_- :                               " + Medium.RemoveSpecialCharacters("Remove%Specials£_-"));

            Task.PrintLine(150);
            Task.DisplaySingularOrPlural();
            Console.WriteLine($"\nTrees :                                           " + Very_Easy.IsPlural("Trees"));

            Task.PrintLine(150);
            Task.DisplayValidateEmailTask();
            Console.Write("\n@edabit.com :              "); Medium.ValidateEmail("@edabit.com");
            Console.Write("\n@edabit :                  "); Medium.ValidateEmail("@edabit");
            Console.Write("\nmatt@edabit.com :          "); Medium.ValidateEmail("matt@edabit.com");
            Console.Write("\n :                         "); Medium.ValidateEmail("");
            Console.Write("\nhello.gmail@com :          "); Medium.ValidateEmail("hello.gmail@com");
            Console.Write("\nbill.gates@microsoft.com : "); Medium.ValidateEmail("bill.gates@microsoft.com");
            Console.Write("\nhello@email :              "); Medium.ValidateEmail("hello@email");
            Console.Write("\n%^%$#%^% :                 "); Medium.ValidateEmail("%^%$#%^%");
            Console.Write("\nwww.email.com :            "); Medium.ValidateEmail("www.email.com");
            Console.Write("\nemail :                    "); Medium.ValidateEmail("email");
            Console.WriteLine("");








            Console.ReadLine();
        }
    }
}
