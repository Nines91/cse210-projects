using System;


public class PromptGenerator
{  

    public int randomNumber;

    public List<string> _questionList = new List<string>();
    public void DisplayPrompt() 
    {
        Console.WriteLine(_questionList[randomNumber]);
        
    }

}