    class Program {

        public static void Main() {
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to Happy Book Club 😊 📚 \n");
            Console.WriteLine("Here are our premium members favorite Books \n");
           
            List<Book> favBooks = SeedBooks();

            List<List<Book>> rList = SeedReadingList();

            List<Member> members = SeedMembers(favBooks,rList);
            
            foreach (var member in members)
            {
                Console.WriteLine($"Books on {member.firstName}'s reading list:");
                foreach (var book in member.readingList)
                {
                    Console.WriteLine($"\t :  {book.title} by {book.author}");    
                }
                Console.WriteLine($"{member.firstName} {member.lastName}'s favorite book is 📖 : {member.favoriteBook?.title} authored by {member.favoriteBook?.author}\n");    
            }
        }
            static List<List<Book>> SeedReadingList() {

                Book freyaBook = new Book("Testing Happiness", "Mina Tyagi");
                var freyaList = new List<Book>{freyaBook};
                
                Book mikhaelBook1 = new Book("Who let the dogs out", "Bow Bow");
                Book mikhaelBook2 = new Book("The story of my Happylife", "Lol Lol");
                var mikhaelList = new List<Book>{mikhaelBook1, mikhaelBook2};

                Book shwethaBook1 = new Book("Eternal Happiness dance", "Sanskari Baccha");
                Book shwethaBook2 = new Book("Happiness is in travel", "Narendra Modi");
                Book shwethaBook3 = new Book("Money is ultimate Happiness", "Donald Trump");

                var shwethaList = new List<Book> {shwethaBook1, shwethaBook2, shwethaBook3};

                var recommendedBooks = new List<List<Book>>{
                    freyaList, mikhaelList, shwethaList
                };
                return recommendedBooks;
            }
        
           static List<Book> SeedBooks() {
            Book favoriteBook1 = new Book("Happy Days", "Nikhil Sharma");
            Book favoriteBook2 = new Book("Are we really happy?", "Deepak Chatterjee");
            Book favoriteBook3 = new Book("The endless search for happiness", "Hunh Win Thahn");

            var favoriteBooks = new List<Book>{
                favoriteBook1, favoriteBook2, favoriteBook3
            };
            return favoriteBooks;
        }

            static List<Member> SeedMembers(List<Book> favBooks, List<List<Book>> rList) {
            Member premiumMember1 = new Member( "Freya", "Pal", favBooks[0], rList[0]);
            Member premiumMember2 = new Member( "Mikhael", "Gorbachev", favBooks[1] , rList[1]);
            Member premiumMember3 = new Member( "Shwetha", "Sivaraman", favBooks[2], rList[2]);

            var members = new List<Member>{
                premiumMember1, premiumMember2, premiumMember3
            };

            return members;
            }   

    }

  



