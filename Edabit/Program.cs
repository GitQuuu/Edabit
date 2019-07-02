using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A run through edabit challenges\n");

            

            Code methods = new Code();

            Console.WriteLine(Code.RemoveSpecialCharacters("Remove%Specials£_-"));

            Code.IsPlural("Trees");

            Console.Write("\n@edabit.com :              ");                 Code.ValidateEmail("@edabit.com");
            Console.Write("\n@edabit :                  ");                     Code.ValidateEmail("@edabit");
            Console.Write("\nmatt@edabit.com :          ");             Code.ValidateEmail("matt@edabit.com");
            Console.Write("\n :                         ");                            Code.ValidateEmail("");
            Console.Write("\nhello.gmail@com :          ");             Code.ValidateEmail("hello.gmail@com");
            Console.Write("\nbill.gates@microsoft.com : ");    Code.ValidateEmail("bill.gates@microsoft.com");
            Console.Write("\nhello@email :              ");                 Code.ValidateEmail("hello@email");
            Console.Write("\n%^%$#%^% :                 ");                    Code.ValidateEmail("%^%$#%^%");
            Console.Write("\nwww.email.com :            ");               Code.ValidateEmail("www.email.com");
            Console.Write("\nemail :                    ");                       Code.ValidateEmail("email");

            Console.ReadLine();
        }
    }
}
