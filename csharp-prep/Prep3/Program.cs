using System;

class Program
{
    static void Main(string[] args)
    {
     // this block of code will run steps 1 and 2    
        //Console.WriteLine("What is the magic number? ");
        //string valueFromUser = Console.ReadLine();
        //int magicNumber = int.Parse(valueFromUser);

    // This block of code will run step 3 using the random number generator with strechs
        
        
        int guess = 0;
        
        string input ="yes";

        while (input == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int attemps = 0;

            do
            {
                attemps += 1;
                Console.WriteLine("What is your guess?");
                string valueFromUser2 = Console.ReadLine();
                guess = int.Parse(valueFromUser2);
                if (magicNumber > guess) 
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess) 
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (magicNumber != guess);
            Console.WriteLine($"You guessed {attemps} times.");

            Console.Write("Do you want to continue? ");
                input = Console.ReadLine();   
            Console.WriteLine("");   
        }

        Console.Write("Thank you for playing !");
    } 
}