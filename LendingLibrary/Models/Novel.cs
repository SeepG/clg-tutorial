namespace LendingLibrary.Models{
    public class Novel : Book {
    public string Genre { get; set; }

    public Novel(string title, string authorName, int pYear, string genreName) { 
        Title = title;
        Author = authorName;
        PublicationYear = pYear;
        Genre = genreName;
    }
    public void ShowNovels() 
    {Console.WriteLine($"\t - {Genre}: {Title} by {Author} was published in {PublicationYear}.");}
    }

}