
class Member { 

    public string firstName;
    public string lastName;
    public Book? favoriteBook;

    public  List<Book> readingList;

    public Member(string fName, string lName, Book favBook, List<Book>rList){
        firstName = fName;
        lastName = lName;
        favoriteBook = favBook;
        readingList = rList;
    }
    public Member(string fName, string lName){
        firstName = fName;
        lastName = lName;
        readingList = new List<Book>();
    } 
 }