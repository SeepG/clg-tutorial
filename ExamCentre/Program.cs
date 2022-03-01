
using ExamCentre.Models;

namespace ExamCentre{
class Program {

public static void Main()
    {
       Console.WriteLine("Exam Centre Mark Sheet\n");

        List<Student> students = SeedStudents();
        Exam exam1 = new Exam("Data Types");

        exam1.AddStudent(students[0]);
        exam1.AddStudent(students[1]);
        exam1.AddStudent(students[2]);

        // List<Exam> exams = SeedExams();
        // exams = AddStudent(exams,students);

        exam1.MarkPaper(3315, 45);
        exam1.MarkPaper(3316, 90);
        exam1.MarkPaper(3317, 60);

        Console.WriteLine($"{exam1.Subject}\n");

        foreach (var student in exam1.students)
            {    
                Console.WriteLine($"{student.candidateId}: {student.score}\n");
		    }   	
    }
        static List<Student> SeedStudents (){
        Student student1 = new Student("Ara", 3315);
        Student student2 = new Student("Eliza", 3316);
        Student student3 = new Student("Aaron", 3317);

        List<Student> students = new List<Student> { student1, student2, student3 };
        return students;
        }
       /* static List<Exam> SeedExams (){
        Exam exam1 = new Exam("Data Types");
        Exam exam2 = new Exam("Methods");

        List<Exam> exams = new List<Exam> { exam1, exam2 };
        return exams;
        }

        static List<Exam> AddStudent(List<Exam> exams, List<Student> students){
        var updatedExams = new List<Exam>();
        foreach (var exam in exams)
        {
          var updatedExam = new Exam(exam.Subject);
           foreach (var student in students)
           {
               updatedExam.AddStudent(student);
           }
           updatedExams.Add(updatedExam);
        }

        return updatedExams;
    }*/

    }
}