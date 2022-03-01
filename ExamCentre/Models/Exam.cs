
namespace ExamCentre.Models;
class Exam {
    public string Subject;
    internal List<Student> students;

    public Exam(string subjectName){
        Subject = subjectName;
        students = new List<Student>();
    }

    public void AddStudent(Student student){
        students.Add(student);
    }

    public void MarkPaper(int candidateId, int marks){
        var student = students.Find(student => student.candidateId == candidateId);
        student!.GetScore(marks);
    }
    
}