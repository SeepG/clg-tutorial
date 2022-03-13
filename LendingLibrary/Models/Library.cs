   namespace LendingLibrary.Models; 
    public class Library {
    
    public string Name { get; private set; }
    public List<TextBook> textBooks = new List<TextBook>();
    public List<Novel> novels = new List<Novel>();
    public List<Album> albums = new List<Album>();
    public List<AudioBook> audioBooks = new List<AudioBook>();

    public Library(string name){
        Name = name;
    }
    public void SeedNovels(){
        novels.Add(new Novel("To kill a mocking bird", "Harper Lee", 1960, "Southern Gothic Fiction"));
        novels.Add(new Novel("The Great Gatsby", "F. Scott Fitzgerald", 1925,  "Tragedy"));
        novels.Add(new Novel("The Pride and Prejudice", "Jane Austen", 1813,  "Romance"));
        ListNovels();
    }
    public void ListNovels(){
        Console.WriteLine($"{Name} - List of Novels:\n");
        foreach (var novel in novels)
        {
            novel.ShowNovels();
        }
    }
    public void SeedTextBooks(){
        textBooks.Add(new TextBook("English for young adults", "Mat Brawford", 2019, "English"));
        textBooks.Add(new TextBook("Story of Maya civilization", "Graham Hancock", 1995, "History"));
        textBooks.Add(new TextBook("Life - The science of Biology", "David W Hall", 2020, "Biology"));
        ListTextBooks();
    }
    public void ListTextBooks()
    {
        Console.WriteLine($"{Name} - List of TextBooks:\n");
        foreach (var textBook in textBooks)
        {
            textBook.ShowTextBooks();
        }
    }
    public void SeedAudioBooks(){
        audioBooks.Add(new AudioBook("A Christmas Carol","Charles Dickens", 2010, 7));
        audioBooks.Add(new AudioBook("The wonderful world of Oz","L. Frank Braun", 2012, 10));
        audioBooks.Add(new AudioBook("Dracula","Bram Stroker", 2012, 8));

        ListAudioBooks();
    }

    public void ListAudioBooks(){
        Console.WriteLine($"{Name} - List of AudioBooks:\n");

        foreach (AudioBook audioBook in audioBooks)
        {
            audioBook.ShowAudioBooks();
        }
    }


    public void SeedAlbums(){
        albums.Add(new Album("Dónde Están los Ladrones", "Shakira", 1998, 5));
        albums.Add (new Album ("Nick of Time", "Bonnie Raitt", 1989, 8));
        albums.Add (new Album ("Heart like a wheel", "Linda Ronstadt", 1975, 10));

        ListAlbums();
    }
      public void ListAlbums()
        {
            Console.WriteLine($"{Name} - List of Albums:\n");
            foreach (var album in albums)
            {
                album.ShowAlbums();
            }
        }
}
