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

            Code.ValidateEmail("@edabit.com");
            Code.ValidateEmail("@edabit");
            Code.ValidateEmail("matt@edabit.com");
            Code.ValidateEmail("");
            Code.ValidateEmail("hello.gmail@com");
            Code.ValidateEmail("bill.gates@microsoftcom");
            Code.ValidateEmail("hello@email");
            Code.ValidateEmail("%^%$#%^%");
            Code.ValidateEmail("www.email.com");
            Code.ValidateEmail("email");

            Console.ReadLine();
        }
    }
}
