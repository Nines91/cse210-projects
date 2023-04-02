using System;

public class Reception : Events //Here Reception class is a child class.
{
    private string _email;

//Creating a new instance with the specified parameters.
    public Reception (string type, string eventName, string descriptions, string date, string time,string address,string email) : base(type, eventName, descriptions, date, time,address)
    {
        _email = email;
    }

    public void ReceptionShortDescription() //This method inherit the shortDescription method from the Event parent class.
    {   
        Console.WriteLine("\n****** Short Descriprion Evenet ******\n");
        ShortDescription();
    }

    public void ReceptionStandardDetails() //This method inherit the StandardDetails method from the Event parent class.
    {
        Console.WriteLine("\n****** Standard Descriprion Evenet ******\n");
        StandardDetails();
    }
    public void FullDetail(string type)
    {
        Console.WriteLine("\n****** Full Descriprion Evenet ******\n");
        Console.WriteLine($"Event type: {type}");
        Console.WriteLine($"RSVP: {_email}");
        StandardDetails(); 
    }
}