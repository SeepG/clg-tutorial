
using ExamCentre.Models;

namespace ExamCentre{
class Program {

public static void Main()
    {
       Console.WriteLine("Exam Centre\n");

        List<Student> students = SeedStudents();
        
        var exam = new Exam("C#");

        exam.AddStudent(students[0]);
        exam.AddStudent(students[1]);
        exam.AddStudent(students[2]);

        exam.MarkPaper(3315, 45);
        exam.MarkPaper(3316, 90);
        exam.MarkPaper(3317, 60);

        Console.WriteLine("Marks for C# students are as follows\n");

        foreach (var student in exam.students)
            {   
                Console.WriteLine($"{student.candidateId}: {student.score}");
		    }	
    }
        static List<Student> SeedStudents (){
        Student student1 = new Student("Ara", 3315);
        Student student2 = new Student("Eliza", 3316);
        Student student3 = new Student("Aaron", 3317);

        var students = new List<Student> { student1, student2, student3 };
        return students;
        }
    
    }
}