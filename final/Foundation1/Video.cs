using System;

//Creating a Video class that will track the title, the author and the length of the video in seconds.
// Also tracks the a list of comments of each video
public class Video 
{
    //Creating member variables.
    public string _videoTitle = "";
    public string _authorName = "";
    public int _durationInSeconds = 0;
    
    

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {_videoTitle}.");
        Console.WriteLine($"Author: {_authorName}.");
        Console.WriteLine($"Duration: {_durationInSeconds} seconds.\n"); 
    }

    

}