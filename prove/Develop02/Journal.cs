using System;
using System.IO;


public class Journal {
    public string _fileName = "My Journal.txt";
    
    public string _userInput = "";

    public Journal () {

    }
    
    public void SaveEntry() {

        using (var fileStream = new FileStream(_fileName, FileMode.Append)) {
            using (var streamWriter = new StreamWriter(fileStream)) {
                DateTime _currentDate = DateTime.Now;
                streamWriter.WriteLine($"{_currentDate.ToLongDateString()}");  
                streamWriter.WriteLine($"{_userInput}");
                streamWriter.WriteLine("");
            }
        }
    }

    public void LoadJournal () {
        using (var fileStream = new FileStream(_fileName, FileMode.Open)) {
            using (var streamReader = new StreamReader(fileStream)) {
                while (!streamReader.EndOfStream) {
                    Console.WriteLine(streamReader.ReadLine());
                }
            }   

        }
    }
}
