namespace LendingLibrary.Models {

    public class Album : Cd {
    public string Artist { get; set; }
    public Album(string title, string artistName, int pYear, int numOfTracks) { 
        Title = title;
        Artist = artistName;
        PublicationYear = pYear;
        NumberOfTracks = numOfTracks;
    }
    public void ShowAlbums() 
    {Console.WriteLine($"\t - {Title}: Album by {Artist} was released in {PublicationYear} and has {NumberOfTracks} tracks.");}
    }
}