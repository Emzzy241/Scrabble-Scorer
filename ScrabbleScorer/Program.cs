using System;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Models
{
    public class Program
    {
        // bn=
        static void Main()
        {
            Console.WriteLine("Scrabble Score Calculator");
            Console.WriteLine();
            Console.WriteLine();
            try
            {
                Console.Write("Enter a word: ");
                string inputWord = Console.ReadLine();

                MyScrabbleScorer newScrabble = new MyScrabbleScorer(inputWord);

                int scrabbleScore = newScrabble.ScrabbleScoreDeterminer();
                Console.WriteLine();
                Console.WriteLine();
                
                Console.WriteLine($"The Scrabble score for '{inputWord}' is: {scrabbleScore}");
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("To play again. Enter 'Y', to exit enter 'N");
                string userContinue = Console.ReadLine().ToUpper();

                if (userContinue == "Y")
                {
                    Console.WriteLine();
                    Console.WriteLine("Okay, lets play again");
                    Console.WriteLine();
                    Main();
                }
                else if (userContinue == "N")
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, I did not get that. Please try again");
                    Console.WriteLine();
                    Main();
                }

            }
            catch 
            {
                Console.WriteLine("Ooops!!!");
                Console.WriteLine("Enter only numbers please. Try again");
                Console.WriteLine();
                Console.WriteLine();
                 Main();
            }

        }        
    }
}