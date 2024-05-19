using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    internal class Student
    {
        private List<Grade> grades;

        public Student()
        {
            grades = new List<Grade>();
        }

        public void AddGrade(Grade grade)
        {
            grades.Add(grade);
        }

        public void GetAllGrades()
        {
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i].Degree);
            }
        }
    }
}
