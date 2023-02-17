using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        
        Console.WriteLine("");

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fraction", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment writing = new WritingAssignment ("Mary Waters", "European History", "The Causes of World War II"); 
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        
        
    }
}