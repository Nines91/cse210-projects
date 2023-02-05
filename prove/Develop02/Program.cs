using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator _questions = new PromptGenerator();
        Entry _entry = new Entry();
        Journal _journal = new Journal();

        //Here we can add the questions to a list that are in the PromptGenerator class.
        _questions._questionList.Add("What is the best thing that happened today?");
        _questions._questionList.Add("With whom have you talked today that made you feel happy?");
        _questions._questionList.Add("Where did you go today?");
        _questions._questionList.Add("Did you do something important today?");
        _questions._questionList.Add("Name one thing that you did today to shine your light?");

        Random random = new Random();
        int randomNummber = random.Next(0,_questions._questionList.Count);
        _questions.randomNumber = randomNummber; 

        //Star the program.
         Console.WriteLine("Welcome to the Journal program!");
        {
            bool journalMenu = true;
            while (journalMenu == true)
            {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do: ");
            int userOption = int.Parse(Console.ReadLine());
        
            switch (userOption)
                {
                case 1:// Here the program call a DisplayPrompt to show a random prompt tho the user know what about
                       // to write.
                    _questions.DisplayPrompt();                        
                    Console.Write("> ");
                    _journal._userInput = Console.ReadLine();
                    
                    break;
                case 2:// Here the program calls the DisplayEntry method to show the user input adding the date.
                    Console.Write("Date - ");
                    _entry.Date();
                    Console.Write("Prompt - ");
                    _questions.DisplayPrompt();
                    _entry.DisplayEntry(_journal._userInput);
                    
                    break;
                case 3: //Here the progrma calls the LoadJournal method to load the journal from a .txt file.
                    _journal.LoadJournal();
                    break;
                case 4: //Here the progrma calls the SveEntry method to save and add what the user writ to the .txt  
                        //journal file.
                    _journal.SaveEntry();
                    break;
                case 5:
                    Console.WriteLine("See you soon!");
                    journalMenu = false;
                    break;
                }

            }
        }
    }
}