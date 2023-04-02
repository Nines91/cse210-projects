using System;

public class Lectures : Events //Here Lectures class is a child class.
{
    private string _speakerName;
    private int _capacity = 0;
    
    //Creating a new instance with the specified parameters.
    public Lectures(string type, string eventName, string descriptions, string date, string time,string address,string speaker, int capacity) : base(type, eventName, descriptions, date, time,address)
    {
        _speakerName = speaker;
        _capacity = capacity;
    }

    public void LectureShortDescription() //This method inherit the shortDescription method from the Event parent class.
    {   
        Console.WriteLine("\n****** Short Descriprion Evenet ******\n");
        ShortDescription();
    }

    public void LectureStandardDetails() //This method inherit the StandardDetails method from the Event parent class.
    {
        Console.WriteLine("****** Standard Descriprion Evenet ******\n");
        StandardDetails();
    }
    public void FullDetail(string type)
    {
        Console.WriteLine("\n****** Full Descriprion Evenet ******\n");
        Console.WriteLine($"Event type: {type}");
        StandardDetails();
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Max capacity: {_capacity} people.");   
    }
}