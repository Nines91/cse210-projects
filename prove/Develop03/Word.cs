using System;

class Word {
    private string _word = "";
    public Word () {}
    public Word (string word)
    {
        HiddeLetters(word);
    }

    public string HiddeLetters(string word) 
    {
        _word = word.Replace(word, new string('_',word.Length ));  // This line will change all letters of the string to '_' and returnig as a new word.
        return _word;
    }

    public string GetWord () 
    {
        return _word;  //getter for word and returning the new word.
    }

}