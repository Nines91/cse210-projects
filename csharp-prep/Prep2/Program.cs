using System;

class Program
{
    static void Main(string[] args)
    {
        //Asking for the user persentage grade.
        Console.Write("What is your grade percentage?: ");
        String userValue = Console.ReadLine();

        int grade = int.Parse(userValue);
        string letter = "";
        
        if (grade >= 90) {
            letter = "A";
        }
        else if (grade >= 80) {
            letter = "B";
        }
        else if (grade >= 70) {
            letter = "C";
        }
        else if (grade >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        //Strech challenge 1
        string gradeSign = "";
        int lastDigit = grade % 10;
        if ( lastDigit >= 7){
            gradeSign = "+";
        }
        else if ( lastDigit < 3){
            gradeSign = "-";
        }
        else
            gradeSign = " ";
        
        //Strech challenge 2 and 3
        if (grade >= 93 || grade < 60){
            gradeSign = " ";
        }

        Console.WriteLine($"Your letter grade is {letter}{gradeSign}");
        
        if (grade >= 70) {
            Console.WriteLine("Congratulation! Your have passed the course.");
        }
        else {
            Console.WriteLine("Don't worry, keep studing programming.");
        }
    }
}