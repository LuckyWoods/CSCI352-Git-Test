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
            int guessCount = 0;
            while (guessNum != randomNum){
                Console.WriteLine("Guess a number between 0 to 100.");
                guessNum = Console.ReadLine();

                guessCount++;

                if(guessNum < randomNum)
                {
                    Console.WriteLine("Guess is too low!");

                }
                else if(guessNum > randomNum)
                {
                    Console.WriteLine("Guess is too high!");
                }

            }

            Console.WriteLine("It took " + guessCount + " guesses!");

        }
    }
}
