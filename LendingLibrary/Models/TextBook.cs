namespace LendingLibrary.Models{
    public class TextBook : Book {
    public string Subject { get; set; }

   public TextBook(string title, string authorName, int pYear, string subjectName) { 
        Title = title;
        Author = authorName;
        PublicationYear = pYear;
        Subject = subjectName;
        }
    public void ShowTextBooks() 
    {Console.WriteLine($"\t - {Subject}: {Title} by {Author} was published in {PublicationYear}.");}
    }
}