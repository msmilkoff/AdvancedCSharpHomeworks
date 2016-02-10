using System;
using System.Linq;
using System.Text;

namespace  StudentsNamespace
{
    class EnrolledIn2014
    {
        private static void Main()
        {
            var students = StudentsDatabase.GetStudentsList();
            var enrolledByYear = from student in students
                                where student.FacultyNumber.ToString().EndsWith("14")
                                select student;
            foreach (var student in enrolledByYear)
            {
                Console.WriteLine(string.Join(", ", student.Marks));
            }
        }
    }
}
