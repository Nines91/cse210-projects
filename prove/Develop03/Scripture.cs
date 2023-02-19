using System;

class Scripture {
    private List<string> _words = new List<string>();
    private Word _word = new Word();
    private string _scripture = "";
    private string _answer = "";
    private Random _random = new Random();
    private int _index = 0;
    private int _counter = 0;
    private int _changes = 0;
    private int _answerHiddeNumber = 0;
    private string[] words = new string[] {};

    public Scripture(Reference reference, string content) {
        _scripture = content;
        Console.WriteLine($"The scripture is {reference.GetReference()}. How many words do you want to hidde to memorize the scripture.? Select 1-3");
        _answerHiddeNumber = int.Parse(Console.ReadLine());
        do{
            ShowScripture(reference);
            Console.WriteLine("");
            Console.Write("Press Enter to continue or press 'quit' to finish: ");
            _answer = Console.ReadLine();
            if(_changes == _words.Count && _words.Count > 0) {
                _answer = "quit";
            }
            HiddeWords();
        }while(_answer != "quit");
    }

    private void HiddeWords()
    {
        _words.Clear();
        words = _scripture.Split(" ");
        foreach(string word in words) {_words.Add(word);}
        _counter = 0;
        while(_counter < _answerHiddeNumber && _changes < _words.Count)
         {
            _index = _random.Next(_words.Count);
            if(_words[_index].Contains("_")) 
            {
                _index = _random.Next(_words.Count);
            }
            else 
            {
                _word = new Word(_words[_index]);
                _words[_index] = _word.GetWord();
                _counter++;
                _changes++;
            }
         }
         _scripture = string.Join(" ", _words);
    }

    private void ShowScripture(Reference reference)
    {
        Console.Clear();
        Console.Write(reference.GetReference());
        Console.WriteLine(" " + _scripture);
    }
}