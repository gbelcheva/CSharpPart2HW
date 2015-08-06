using System;

public class SimpleMathExam : Exam
{
    private const int BadGradeMaxProblems = 2;
    private const int AverageGradeMaxProblems = 7;
    private const int ExcellentGradeMaxProblems = 10;
    private const int BadGrade = 2;
    private const int AverageGrade = 4;
    private const int ExcellentGrade = 6;
    private const int MinGrade = 2;
    private const int MaxGrade = 6;

    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved 
    {
        get 
        {
            return this.problemsSolved;
        }

        private set
        {
            if (value < 0 || 10 < value)
            {
                throw new ArgumentOutOfRangeException("Solved problems must be between 0 and " + ExcellentGradeMaxProblems);
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved <= BadGradeMaxProblems)
        {
            return new ExamResult(BadGrade, MinGrade, MaxGrade, "Bad result: nothing done.");
        }
        else if (BadGradeMaxProblems < this.ProblemsSolved && this.problemsSolved <= AverageGradeMaxProblems)
        {
            return new ExamResult(AverageGrade, MinGrade, MaxGrade, "Average result: some work is done.");
        }
        
        return new ExamResult(ExcellentGrade, MinGrade, MaxGrade, "Excellent result: almost everyting is done.");
    }
}
