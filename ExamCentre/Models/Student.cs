
namespace ExamCentre.Models;

class Student {
    private string _name;
    internal int candidateId;
    internal int score;

    public Student(string studentName, int candidateIdNumber){
        _name = studentName;
        candidateId = candidateIdNumber;
    }

    public void SetScore(int scoreNumber){
    score = scoreNumber;
    }
    
}