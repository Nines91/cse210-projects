using System;

public class Entry {
    
   
   public List<string> _promptReference = new List<string>();

    public Entry() 
    {
    }

    public void Date(){
        DateTime _currentDate = DateTime.Now;
        Console.WriteLine($"{_currentDate.ToLongDateString()}");        
    }

    public void DisplayEntry(string entries){
        Console.WriteLine($"{entries}");
    }

    
}

    
