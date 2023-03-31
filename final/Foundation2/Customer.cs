using System;

public class Customer 
{
    private string _customerName = "";
    public Customer (string name)
    {
        _customerName = name;
    }
    //setting the full customer info method about the customer. This method will call the value of the mmember 
    //variables in the main program. And return all the information as a string.
    public string FullCustomerInfo (string info) { 
        string name= "";
        string fullInfo ="";
        name = $"Name: {_customerName}";
        fullInfo = $"{name}\n{info}";
        Console.WriteLine("\n      Thank you four trust in US.");
        Console.WriteLine("   **********************************   ");
        return fullInfo;
    }
    
}