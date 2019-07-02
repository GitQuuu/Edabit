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

            Code.ValidateEmail("hellogmail@com");
        
            Console.ReadLine();
        }
    }
}
