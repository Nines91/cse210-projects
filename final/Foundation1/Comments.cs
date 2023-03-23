using System;

//creating the comments class
public class Comments 
{
    //Creating member variables
    public string _namePerson = "";
    public string _commentText = "";
    public int _totalCommentCount = 0;
    public List<Video> _videos = new List<Video>();
    public List <Comments> _comment = new List<Comments> ();
    public void ShowComment ()
    {
        Console.WriteLine($"  ***  {_namePerson} said: {_commentText}");
    }
    public void Display()
    {
        foreach (Video v in _videos) 
        {
             Console.WriteLine("------------------- ******************* -------------------\n");
            v.ShowInfo();
            foreach (Comments c in _comment)
            {
                c.ShowComment();
                _totalCommentCount ++;
            }
            Console.WriteLine($"\n{v._videoTitle} has {_totalCommentCount} comments.\n");
        }        
    }

   
}