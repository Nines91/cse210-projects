using System;

class Program
{
    static void Main(string[] args)
    {
        //You have 2 ways to run this program:  Option 1:  Display all the information at once. 
        // If you want to display all the information please comment all option 2 and uncomment the following code comment.
//Option 1: Display all the information at once        
        //Setting information for the lecture event.
        Address event1address = new Address("3523 Lopez cabrera Street, Cordoba City, Argentina");
        Lectures event1 = new Lectures("Lecture", "How to have a deep learning.", "We will learn how to have a better studying", "April 3rd, 2023","3:00 PM",event1address.GetAddress(), "John Snows", 250);
        //event1.LectureShortDescription();
        //event1.LectureStandardDetails();
        //event1.FullDetail("Lecture");

        //Setting information for the lecture event.
        Address event2address = new Address("635 Baigorrí Street, Cordoba City, Argentina");
        Reception event2 = new Reception("Reception", "Wedding", "Carol & Marck celebration", "June 20th, 2023", "10:00 PM", event2address.GetAddress(),"marky123@gmail.com");
        //event2.ReceptionShortDescription();
        //event2.ReceptionStandardDetails();
        //event2.FullDetail("Reception");

        Address event3address = new Address("2853 Grand River Avenue, Foz do Iguazu, Brazil");
        OutdoorGathering event3 = new OutdoorGathering("Outdoor Gathering", "Zoo Excursion", "Guided tour of the zoo", "May 5th, 2023", "09:00 AM", event3address.GetAddress(),"Sunny");
        //event3.OutdoorShortDescription();
        //event3.OutdoorStandardDetails();
        //event3.FullDetail("Outdoor Gathering");


// Option 2: Display interacttive menu to show the specific information.
         Console.WriteLine("Event viewer:");
        {
            bool viewEvent = true;
            while (viewEvent == true)
            {
            Console.WriteLine("\nWhat type of event do you want to display?");
            Console.WriteLine("1. Lecture");
            Console.WriteLine("2. Recervation");
            Console.WriteLine("3. Outdoor Gathering");
            Console.WriteLine("4. Exit");
            Console.Write("What would you like to do: ");
            int userOption = int.Parse(Console.ReadLine());
        
            switch (userOption)
                {
                    case 1:
                        Console.WriteLine("\nWhat type of detail do you want to know?");
                        Console.WriteLine("1. Short description");
                        Console.WriteLine("2. Standard details");
                        Console.WriteLine("3. Full description"); 
                        Console.Write("Your option is: ");                      
                        int option = int.Parse(Console.ReadLine());
                        switch (option) 
                            {
                                case 1:
                                    event1.LectureShortDescription();
                                break;
                                case 2:
                                    event1.LectureStandardDetails();                               
                                break;
                                case 3:
                                    event1.FullDetail("Lecture");
                                break;
                            }
                    break;
                    case 2:
                        Console.WriteLine("\nWhat type of detail do you want to know?");
                        Console.WriteLine("1. Short description");
                        Console.WriteLine("2. Standard details");
                        Console.WriteLine("3. Full description"); 
                        Console.Write("Your option is: ");
                        int option2 = int.Parse(Console.ReadLine());
                        switch (option2) 
                            {
                                case 1:
                                    event2.ReceptionShortDescription();
                                break;
                                case 2:
                                    event2.ReceptionStandardDetails();                               
                                break;
                                case 3:
                                    event2.FullDetail("Reception");
                                break;
                            }
                    break;
                    case 3:
                        Console.WriteLine("\nWhat type of detail do you want to know?");
                        Console.WriteLine("1. Short description");
                        Console.WriteLine("2. Standard details");
                        Console.WriteLine("3. Full description"); 
                        Console.Write("Your option is: ");
                        int option3 = int.Parse(Console.ReadLine());
                        switch (option3) 
                            {
                                case 1:
                                    event3.OutdoorShortDescription();
                                break;
                                case 2:
                                    event3.OutdoorStandardDetails();                               
                                break;
                                case 3:
                                    event3.FullDetail("Outdoor Gathering");
                                break;
                            }
                    break;
                    case 4:
                        Console.Write("Good-bye!");
                        viewEvent = false;
                    break;
                }
            }
        }

    }
}