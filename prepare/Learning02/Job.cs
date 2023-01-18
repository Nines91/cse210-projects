using System;

//Createing a class named Job.
public class Job {

//Stating variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Job() { 

    }

    public void Display() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} {_endYear}");
    }

}