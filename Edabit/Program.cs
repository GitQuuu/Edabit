using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A run through edabit challenges\n");

            Task.PrintLine(150);
            Task.DisplayFirstAndLastCharacter();
            Console.Write("\nHello Edabit :             "); Console.WriteLine(Code.RemoveFirstLast("Hello Edabit")); 


            Task.PrintLine(150);
            Task.DisplayRemoveSpecialCharacters();
            Console.Write("\nRemove%Specials£_-         "); Console.WriteLine(Code.RemoveSpecialCharacters("Remove%Specials£_-"));
           
           
            Task.PrintLine(150);
            Task.DisplaySingularOrPlural();
            Console.Write("\nTrees                      "); Code.IsPlural("Trees");
           
           
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
