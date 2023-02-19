using System;

class Program
{
    static void Main(string[] args)
    {
        //ScriptureOptions options = new ScriptureOptions();
        Reference reference = new Reference ("2 Nephi 33:2-3");
        //Scripture scripture = new Scripture(reference, options.GetSelectorScripture());

        //Console.Write(reference.GetReference());
        Scripture scripture = new Scripture(reference, "But behold, there are many that harden their hearts against \n"
        + "the Holy Spirit, that it hath no place in them; wherefore, they cast many things away which are written \n"
        + "and esteem them as things of naught.But I, Nephi, have written what I have written, and I esteem it as of \n"
        + "great worth, and especiallycunto my people. For I pray continually for them by day, and mine eyes water my \n"
        + "pillow by night, because of them; and I cry unto my God in faith, and I know that he will hear my cry.");
        
    }
}