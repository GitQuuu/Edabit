﻿using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A run through edabit challenges");

            Code methods = new Code();

            Console.WriteLine(Code.RemoveSpecialCharacters("Remove%Specials£_-")); 
            

            Console.ReadLine();
        }
    }
}
