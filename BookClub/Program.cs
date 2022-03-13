using BookClub.Models;

namespace BookClub {
class Program
{
    public static void Main()
    {
        ConsoleKeyInfo cki;
        Console.WriteLine(" ");
        Console.WriteLine("Welcome to Happy Book Club 😊 📚 \n");

        List<Book> favoriteBooks = SeedBooks();

        List<List<Book>> rList = SeedReadingList();

        List<Member> members = SeedMembers(favoriteBooks, rList);

        do
        {
            Console.WriteLine("What would you like to see or do 🔎 ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            giveInstructions();

            var userInput = Console.ReadLine()!;

            RespondToUserInput(userInput, members);

            cki = Console.ReadKey(true);
        } while (cki.Key != ConsoleKey.Escape);

    }
    static List<List<Book>> SeedReadingList()
    {

        Book freyaBook = new Book("Testing Happiness", "Mina Tyagi");
        var freyaList = new List<Book> { freyaBook };

        Book mikhaelBook1 = new Book("Who let the dogs out", "Bow Bow");
        Book mikhaelBook2 = new Book("The story of my Happylife", "Lol Lol");
        var mikhaelList = new List<Book> { mikhaelBook1, mikhaelBook2 };

        Book shwethaBook1 = new Book("Eternal Happiness dance", "Sanskari Baccha");
        Book shwethaBook2 = new Book("Happiness is in travel", "Narendra Modi");
        Book shwethaBook3 = new Book("Money is ultimate Happiness", "Donald Trump");

        var shwethaList = new List<Book> { shwethaBook1, shwethaBook2, shwethaBook3 };

        var recommendedBooks = new List<List<Book>> { freyaList, mikhaelList, shwethaList };
        return recommendedBooks;
    }

    static List<Book> SeedBooks()
    {
        Book favoriteBook1 = new Book("Happy Days", "Nikhil Sharma");
        Book favoriteBook2 = new Book("Are we really happy?", "Deepak Chatterjee");
        Book favoriteBook3 = new Book("The endless search for happiness", "Hunh Win Thahn");

        var favoriteBooks = new List<Book> { favoriteBook1, favoriteBook2, favoriteBook3 };
        return favoriteBooks;
    }

    static List<Member> SeedMembers(List<Book> favBooks, List<List<Book>> rList)
    {
        Member premiumMember1 = new Member("freya", "pal", favBooks[0], rList[0]);
        Member premiumMember2 = new Member("mikhael", "gorbachev", favBooks[1], rList[1]);
        Member premiumMember3 = new Member("shwetha", "sivaraman", favBooks[2], rList[2]);

        var members = new List<Member> { premiumMember1, premiumMember2, premiumMember3 };
        return members;
    }

    static void RespondToUserInput(string userInput, List<Member> members)
    {
        switch (userInput)
        {
            case "1":

                foreach (var member in members)
                {
                    foreach (var book in member.readingList!)
                    {
                        Console.WriteLine($"\t :  {book.title} by {book.author}\n");
                    }
                }
                break;

            case "2":

                foreach (var member in members)
                {
                    Console.WriteLine($"\t{member.firstName}'s favorite book is 📖 : {member.favoriteBook?.title} authored by {member.favoriteBook?.author}\n");
                }
                break;

            case "3":

                foreach (var member in members)
                {
                    Console.WriteLine($"\t{member.firstName} {member.lastName}\n");
                }
                break;
            case "4":
                var newMember = addMember();
                members.Add(newMember);
                break;

            case "5":
                Console.Write("Confirm First name of member for whom you are adding Book\n");
                var memberFirstName = Console.ReadLine()?.Trim();
                Console.Write("Confirm Last name of member for whom you are adding Book\n");
                var memberLastName = Console.ReadLine()?.Trim();
                var selectedMember = new Member(memberFirstName!, memberLastName!);
                selectedMember = members.Find(m => m.firstName == memberFirstName && m.lastName == memberLastName);

                if (selectedMember != null)
                {
                    Console.Write("Enter Book Title you want to Add\n");
                    var newBookTitle = Console.ReadLine()?.Trim();
                    Console.Write("Enter the Book Author you want to Add\n");
                    var newBookAuthor = Console.ReadLine()?.Trim();
                    var newBook = new Book(newBookTitle!, newBookAuthor!);
                    selectedMember.readingList.Add(newBook);
                }
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    static void giveInstructions()
    {
        Console.WriteLine("Pick your list options below: \n");
        Console.WriteLine("\t1 - Show Recommended Books:");
        Console.WriteLine("\t2 - Show members favorite Books");
        Console.WriteLine("\t3 - Show existing members");
        Console.WriteLine("\t4 - Add new Members");
        Console.WriteLine("\t5 - Add new Recommended Books for members\n");
        Console.WriteLine("\tPress <ESCAPE> (Esc) key to quit or any key to continue\n");
    }

    static Member addMember()
    {
        Console.Write("Enter First name of new member you want to Add\n");
        var newMemberFirstName = Console.ReadLine()?.Trim();
        Console.Write("Enter Last name of new member you want to Add\n");
        var newMemberLastName = Console.ReadLine()?.Trim();
        var newMember = new Member(newMemberFirstName!, newMemberLastName!);
        newMember.favoriteBook = addFavoriteBook();
        return newMember;
    }

    static Book addFavoriteBook()
    {
        Console.Write("Enter Book Title you want to Add\n");
        var favoriteBookTitle = Console.ReadLine()?.Trim();
        Console.Write("Enter the Book Author you want to Add\n");
        var favoriteBookAuthor = Console.ReadLine()?.Trim();
        return new Book(favoriteBookTitle!, favoriteBookAuthor!);
        }
    }
}


