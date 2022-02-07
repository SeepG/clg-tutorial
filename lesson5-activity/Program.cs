Console.WriteLine(" ");

Console.WriteLine("Welcome to Hogwarts finder 🏰");

var students = new List<String> { "Harry Potter, Hermione Granger, Ron Weasley, Draco Malfoy, Neville Longbottom, Luna Lovegood" };

var courses = new List<String> { "Dark Arts, Potions, Magical Creatures\n" };

Dictionary<string, string> coursesOfEachStudent = new Dictionary<string, string>();
coursesOfEachStudent.Add("Harry Potter", "Dark Arts");
coursesOfEachStudent.Add("Hermonie Grangers", "Potions");
coursesOfEachStudent.Add("Ron Weasley", "Magical Creatures");
coursesOfEachStudent.Add("Draco Malfoy", "Dark Arts");
coursesOfEachStudent.Add("Neville Longbottom", "Potions");
coursesOfEachStudent.Add("Luna Lovegood", "Magical Creatures");

while (true)
{
  Console.WriteLine("What would you like to see or do 🔎 ");
  Console.WriteLine(" ");
  Console.ForegroundColor = ConsoleColor.DarkRed;

  Console.WriteLine("Enter 1 - See a list of students at the university:");
  Console.WriteLine("Enter 2 - See a list of courses at the university:");
  Console.WriteLine("Enter 3 - List the courses each student is enrolled on:");

  Console.WriteLine("Enter 4 - Enrol a new student at the university");
  Console.WriteLine("Enter 5 - Unenrol a student");
  Console.WriteLine("Enter 6 - Add a new course to the university catalogue");
  Console.WriteLine("Enter 7 - Remove a course from the university catalogue");

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
        Console.WriteLine($"\t{student}\n");
      }
      break;
    case "2":
      Console.WriteLine("Here is a list of courses offered\n");

      foreach (var course in courses)
      {
        Console.WriteLine($"\t{course}\n");
      }
      break;
    case "3":
      Console.WriteLine("Here is a list of courses each student is enrolled on: \n");

      foreach(KeyValuePair<string, string> element in coursesOfEachStudent)
          {
              Console.WriteLine($"\t{element.Key} is in {element.Value}\n");
          }
          break;
    case "4":
      Console.WriteLine("Enter the name of new student you want to Enrol\n");
      var newStudent = " ";
      newStudent = Console.ReadLine()?.Trim();
      students.Add(newStudent!);
      break;
    case "5":
      Console.WriteLine("Enter the name of student you want to Unenrol\n");
      var removeStudent = " ";
      removeStudent = Console.ReadLine()?.Trim();
      students.Remove(removeStudent!);
      break;
    case "6":
      Console.WriteLine("Please share the course you want to Add\n");
      var addCourse = " ";
      addCourse = Console.ReadLine()?.Trim();
      courses.Add(addCourse!);
      break;
    case "7":
      Console.WriteLine("Pick the course you want to Remove\n");
      var removeCourse = " ";
      removeCourse = Console.ReadLine()?.Trim();
      courses.Remove(removeCourse!);
      break;
    default:
      Console.WriteLine(" ");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("Sorry. I didn't recognise that command. Please enter your option again\n");
      Console.WriteLine("Enter 1 - See a list of students at the university:");
      Console.WriteLine("Enter 2 - See a list of courses at the university:");
      Console.WriteLine("Enter 3 - List the courses each student is enrolled on: ");
      
      Console.WriteLine("Enter 4 - Enrol a new student at the university");
      Console.WriteLine("Enter 5 - Unenrol a student");
      Console.WriteLine("Enter 6 - Add a new course to the university catalogue");
      Console.WriteLine("Enter 7 - Remove a course from the university catalogue");
      break;
  }
}
