using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the youtube video tracker program.\nYou will know some basic information about your videos.\n");
        Console.WriteLine("Comments:");    
    /*-------------------------------Setting the video 1-------------------------------*/ 
        Video v1 = new Video();
        v1._videoTitle = "Hello Foundation1 World!";
        v1._authorName = "Nicolas Ines";
        v1._durationInSeconds = 360;

        Comments v1Comments = new Comments();
        v1Comments._namePerson = ("Juan Perez");
        v1Comments._commentText = ("This is a comment for the video 1");
 
        Comments v1_1Comments = new();
        v1_1Comments._namePerson = ("Cristina Cabrera");
        v1_1Comments._commentText = ("What a great video!!!"); 

        Comments v1_2Comments = new();
        v1_2Comments._namePerson = ("Lucas Librandi");
        v1_2Comments._commentText = ("Thanks for the video.");

        Comments v1_3Comments = new();
        v1_3Comments._namePerson = ("Jhon Calver");
        v1_3Comments._commentText = ("Was a little bored.");
        
        Comments comment1 = new Comments();
        comment1._videos.Add(v1);
        comment1._comment.Add(v1Comments);
        comment1._comment.Add(v1_1Comments);
        comment1._comment.Add(v1_2Comments);
        comment1._comment.Add(v1_3Comments);
        comment1.Display();
    
    /*-------------------------------Setting the video 2-------------------------------*/  
        Video v2 = new Video();
        v2._videoTitle = "Hello World!";
        v2._authorName = "Nicolas Ines";
        v2._durationInSeconds = 120;

        Comments v2Comments = new Comments();
        v1Comments._namePerson = ("Josue Fernandez");
        v1Comments._commentText = ("Interesting introduction to programming.");
 
        Comments v2_1Comments = new();
        v2_1Comments._namePerson = ("Alexia Hall");
        v2_1Comments._commentText = ("I'm so motivated to learning more."); 

        Comments v2_2Comments = new();
        v2_2Comments._namePerson = ("Bruno Mattio");
        v2_2Comments._commentText = ("I did the excercises. Was easy to learn.");

        Comments v2_3Comments = new();
        v2_3Comments._namePerson = ("Jhon Calver");
        v2_3Comments._commentText = ("Was a little bored.");
        
        Comments comment2 = new Comments();
        comment2._videos.Add(v2);
        comment2._comment.Add(v2Comments);
        comment2._comment.Add(v2_1Comments);
        comment2._comment.Add(v2_2Comments);
        comment2._comment.Add(v2_3Comments);
        comment2.Display();
/*-------------------------------Setting the video 3-------------------------------*/ 
        Video v3 = new Video();
        v3._videoTitle = "Solid Crypto";
        v3._authorName ="Lucas Librandi";
        v3._durationInSeconds = 420;

        Comments v3Comments = new Comments();
        v3Comments._namePerson = ("Nicolas Ines");
        v3Comments._commentText = ("I can understand how works the crypto world.");
 
        Comments v3_1Comments = new();
        v3_1Comments._namePerson = ("Carola Smith");
        v3_1Comments._commentText = ("The explanation is so clearly."); 

        Comments v3_2Comments = new();
        v3_2Comments._namePerson = ("Charles Flin");
        v3_2Comments._commentText = ("I want't more videos like this!!!");

        Comments comment3 = new Comments();
        comment3._videos.Add(v3);
        comment3._comment.Add(v3Comments);
        comment3._comment.Add(v3_1Comments);
        comment3._comment.Add(v3_2Comments);
        comment3.Display();

    
/*-------------------------------Setting the video 4-------------------------------*/ 
        Video v4 = new Video();
        v4._videoTitle = "My healing journey";
        v4._authorName ="Cristina Cabrera";
        v4._durationInSeconds = 600;

        Comments v4Comments = new Comments();
        v4Comments._namePerson = ("Alba Posse");
        v4Comments._commentText = ("You can make me remember many things.");
 
        Comments v4_1Comments = new();
        v4_1Comments._namePerson = ("Christopher Wells");
        v4_1Comments._commentText = ("Thank you."); 

        Comments v4_2Comments = new();
        v4_2Comments._namePerson = ("Veronica Grant");
        v4_2Comments._commentText = ("I feel very comfortable");

        Comments v4_3Comments = new();
        v4_3Comments._namePerson = ("Lauren");
        v4_3Comments._commentText = ("Good video. Thanks.");

        Comments v4_4Comments = new();
        v4_4Comments._namePerson = ("Charles Flin");
        v4_4Comments._commentText = ("I want't more videos like this!!!");

        Comments comment4 = new Comments();
        comment4._videos.Add(v4);
        comment4._comment.Add(v4Comments);
        comment4._comment.Add(v4_1Comments);
        comment4._comment.Add(v4_2Comments);
        comment4._comment.Add(v4_3Comments);
        comment4._comment.Add(v4_4Comments);
        comment4.Display();
    
    }
}