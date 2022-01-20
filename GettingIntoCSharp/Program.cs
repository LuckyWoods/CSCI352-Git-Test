using System;

namespace GettingIntoCSharp
{
    class Program
    {
        /* static void Main(string[] args)
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
         }*/

        static void Main(string[] args)
        {
            int guessNum = 0;
            Random numberGuess = new Random();
            int guessCount = 0;


            Console.WriteLine("What is lowest number to guess?");
            string intConvertX = Console.ReadLine();
            int x = int.Parse(intConvertX);
            Console.WriteLine("What is highest number to guess?");
            string intConvertY = Console.ReadLine();
            int y = int.Parse(intConvertY);


            int ranNumber = numberGuess.Next(x, y);
            while (guessNum != ranNumber)
            {
                Console.WriteLine("Guess a number between " + x + " to " + y + ".");
                string intConvert = Console.ReadLine();

                guessNum = int.Parse(intConvert);

                guessCount++;

                if(guessNum < ranNumber)
                {
                    Console.WriteLine("Guess is too low!");

                }
                else if(guessNum > ranNumber)
                {
                    Console.WriteLine("Guess is too high!");
                }

            }

            Console.WriteLine("It took " + guessCount + " guesses!");

        }
    }
}
