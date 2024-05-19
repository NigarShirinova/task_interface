using task15;

class Program
{
    static void Main(string[] args)
    {

        Student student = new Student();

        student.AddGrade(new Grade("Math", Degree.A));
        student.AddGrade(new Grade("Science", Degree.B));
        student.AddGrade(new Grade("History", Degree.C));


       student.GetAllGrades();
        
    }
}