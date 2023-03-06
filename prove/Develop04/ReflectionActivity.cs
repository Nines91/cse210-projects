using System;

public class ReflectionActivity : Activity 
{
    public int ranNumber = 0;
    public int randNumberQ = 0;
    public List<string> _Prompts = new List<string>();
    public List<string> _Questions = new List<string>();
    
    public ReflectionActivity ()
    {
        
    }
    public ReflectionActivity (string name, string description) : base(name, description) 
    {

    }

    public ReflectionActivity (int duration, int num, int num1) : base(duration)
    {   
        int _num = num; 
        int _num1 = num1;
        RunActivity(duration, _num, _num1);
    }

    public void RunActivity(int duration, int num, int num1) 
    {  
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.Write("  --- ");
        RandomPrompt(num);
        Console.WriteLine(" --- ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        if (userInput == string.Empty)
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
                for (int i = 6; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.Clear();
                DateTime start = DateTime.Now;
                DateTime endTime = start.AddSeconds(duration);
                while (DateTime.Now <= endTime) 
                {
                    Console.Write("> ");
                    RandomQuestion (randNumberQ);
                    ShowSpinnerAnimation();
                }
        }
    }

    public void RandomPrompt (int ranNumber)
    {    
        Console.Write((_Prompts[ranNumber])); 
    }

    public void RandomQuestion (int randNumberQ)
    {
        Console.WriteLine(_Questions[randNumberQ]);
    }
    
}