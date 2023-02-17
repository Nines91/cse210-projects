using System;

public class MathAssignment : Assignment {
    private string _textbookSection = "";
    private string _problem = "";

    public MathAssignment(string studentName, string topic, string text, string problem) : base (studentName, topic) 
    {
        _textbookSection = text;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return ($"{_textbookSection} {_problem}");
    }
}