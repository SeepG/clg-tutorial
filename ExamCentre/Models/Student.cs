
namespace ExamCentre.Models;

class Student {
    private string name;
    internal int candidateId;
    internal int score;

    public Student(string studentName, int candidateIdNumber){
        name = studentName;
        candidateId = candidateIdNumber;
    }

    public void GetScore(int scoreNumber){
    score = scoreNumber;
    }
}