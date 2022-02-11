/*
The aim of this activity is to create a simple book club application, 
that stores details of members of a book club and the books they like to read.

Task 1
Display in the console a list of all the members along with their favorite book.

Task 2.
- Allow each member to have a list of books on their reading list 
- Display each book on each member’s reading list

*/
    class Program {

        public static void Main() {
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to Happy Book Club 😊 📚 \n");
            Console.WriteLine("Here are our premium members favorite Books \n");
           
            // List<Book> favBooks = SeedBooks();

            Book favoriteBook1 = new Book("Happy Days", "Nikhil Sharma");
            Book favoriteBook2 = new Book("Are we really happy?", "Deepak Chatterjee");
            Book favoriteBook3 = new Book("The endless search for happiness", "Hunh Win Thahn");

            var rList = new List<Book> { 
                new Book("Testing Happiness", "Mina Tyagi"), 
                new Book("Who let the dogs out", "Bow Bow"), 
                new Book("The story of my Happylife", "Lol Lol"), 
                };

            var premiumMember1 = new Member( "Freya", "Pal", favoriteBook1, rList);
            var premiumMember2 = new Member( "Mikhael", "Gorbachev", favoriteBook2 , rList);
            var premiumMember3 = new Member( "Shwetha", "Sivaraman", favoriteBook3, rList);

            var members = new List<Member>{
                premiumMember1, premiumMember2, premiumMember3
            };

            foreach (var member in members)
            {
                Console.WriteLine($"Books on {member.firstName}'s reading list:");
                foreach (var book in member.readingList)
                {
                    Console.WriteLine($"\t :  📖 {book.title} by {book.author}");    
                }
                Console.WriteLine($"\t :  {member.firstName} {member.lastName}'s favorite book 📖 is {member.favoriteBook?.title} authored by {member.favoriteBook?.author}");    
            }
        }
        
        //    static List<Book> SeedBooks() {
        //     Book favoriteBook1 = new Book("Happy Days", "Nikhil Sharma");
        //     Book favoriteBook2 = new Book("Are we really happy?", "Deepak Chatterjee");
        //     Book favoriteBook3 = new Book("The endless search for happiness", "Hunh Win Thahn");

        //     var favoriteBooks = new List<Book>{
        //         favoriteBook1, favoriteBook2, favoriteBook3
        //     };
        //     return favoriteBooks;
        // }

        public class Member {
            public string? firstName;
            public string? lastName;
            public Book? favoriteBook;

            public List<Book> readingList;

            public Member (string fName, string lName, Book fBook, List<Book> rList) {
                firstName = fName;
                lastName = lName;
                favoriteBook = fBook;
                readingList = rList;
            }
        }

        public class Book {
            public string? title;
            public string? author;

            public Book( string titleName, string authorName ){
                title = titleName;
                author = authorName;
            }
        }

       




    }

  



