﻿using System;

namespace GettingIntoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.sayGoodbye();
            Cat c = new Cat();
            Cat j = new Cat("Philbert");
            c.printCat();
            j.printCat();
            Console.ReadKey();
        }
        void sayGoodbye()
        {
            Console.WriteLine("Goodbye World!");
        }
    }
}