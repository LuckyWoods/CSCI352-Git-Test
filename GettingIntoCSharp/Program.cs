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
            int randomNum = 1;
            Random numberGuess = new Random();
            int guessCount = 0;
            int ranNumber = numberGuess.Next(0, 101);
            while (guessNum != ranNumber)
            {
                Console.WriteLine("Guess a number between 0 to 100.");
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
