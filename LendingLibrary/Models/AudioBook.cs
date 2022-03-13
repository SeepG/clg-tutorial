namespace LendingLibrary.Models{

    public class AudioBook : Cd {
    public AudioBook(string title, string authorName, int pYear, int numOfTracks) { 
        Title = title;
        Author = authorName;
        PublicationYear = pYear;
        NumberOfTracks = numOfTracks;
    }
    public void ShowAudioBooks() 
    {Console.WriteLine($"\t - {Title}: Audiobook by {Author} was released in {PublicationYear} and has {NumberOfTracks} tracks.");}
    }

    }