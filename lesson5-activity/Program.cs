Console.WriteLine(" ");

Console.WriteLine("Welcome to Hogwarts finder 🏰");

//Creates list of students 
var students = new List<String> { "Harry Potter, Hermione Granger, Ron Weasley, Draco Malfoy, Neville Longbottom, Luna Lovegood, Vincent Crabbe, Gregory Goyle, Pansy Parkinson" };

//Creates list of courses at Hogwarts 
var courses = new List<String> { "Dark Arts, Potions, Magical Creatures\n" };

while (true)
{
  Console.WriteLine("What would you like to see or do 🔎 ");
  Console.WriteLine(" ");
  Console.ForegroundColor = ConsoleColor.DarkRed;

  Console.WriteLine("Enter 1 = See a list of students at the university");
  Console.WriteLine("Enter 2 = See a list of courses at the university");
  Console.WriteLine("Enter 3 = Enrol a new student at the university");
  Console.WriteLine("Enter 4 = Unenrol a student");
  Console.WriteLine("Enter 5 = Add a new course to the university catalogue");
  Console.WriteLine("Enter 6 = Remove a course from the university catalogue");
  Console.WriteLine(" ");
  Console.WriteLine("0 = Exit");

  Console.ForegroundColor = ConsoleColor.Blue;

  var userInput = Console.ReadLine();

  if (userInput == "0")
  {
    break;
  }

  switch (userInput)
  {
    case "1":
      Console.WriteLine("Here is a list of students\n");

      foreach (var student in students)
      {
        Console.WriteLine(student);
      }
      break;
    case "2":
      Console.WriteLine("Here is a list of courses offered\n");

      foreach (var course in courses)
      {
        Console.WriteLine(course);
      }
      break;
    case "3":
      Console.WriteLine("Enter the name of new student you want to Enrol\n");
      var newStudent = " ";
      newStudent = Console.ReadLine()?.Trim();
      students.Add(newStudent!);
      break;
    case "4":
      Console.WriteLine("Enter the name of student you want to Unenrol\n");
      var removeStudent = " ";
      removeStudent = Console.ReadLine()?.Trim();
      students.Remove(removeStudent!);
      break;
    case "5":
      Console.WriteLine("Please share the course you want to Add\n");
      var addCourse = " ";
      addCourse = Console.ReadLine()?.Trim();
      courses.Add(addCourse!);
      break;
    case "6":
      Console.WriteLine("Pick the course you want to Remove\n");
      var removeCourse = " ";
      removeCourse = Console.ReadLine()?.Trim();
      courses.Remove(removeCourse!);
      break;
    default:
      Console.WriteLine(" ");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("Sorry. I didn't recognise that command. Please enter your option again\n");
      Console.WriteLine("Enter 1 = See a list of students at the university");
      Console.WriteLine("Enter 2 = See a list of courses at the university");
      Console.WriteLine("Enter 3 = Enrol a new student at the university");
      Console.WriteLine("Enter 4 = Unenrol a student");
      Console.WriteLine("Enter 5 = Add a new course to the university catalogue");
      Console.WriteLine("Enter 6 = Remove a course from the university catalogue");
      break;
  }
}
