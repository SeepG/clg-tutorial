using LendingLibrary.Models;

namespace LendingLibrary {

    class Program {

        public static void Main() {
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to Library lending app 📚 \n");
            Console.WriteLine("You can search for Albums, Novels, Textbooks and Audiobooks.\n");
            var library = new Library("Melbourne Library");
            library.SeedNovels();
            Console.WriteLine(" ");
            library.SeedTextBooks();
            Console.WriteLine(" ");
            library.SeedAlbums();
            Console.WriteLine(" ");
            library.SeedAudioBooks();
        }
    }
}