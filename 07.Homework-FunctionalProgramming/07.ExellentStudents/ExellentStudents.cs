using System;
using System.Linq;

namespace StudentsNamespace
{
    class ExellentStudents
    {
        static void Main()
        {
            var students = StudentsDatabase.GetStudentsList();
            var excellentStudents = from student in students
                where student.Marks.Contains(6)
                select student;
            foreach (var student in excellentStudents)
            {
                Console.WriteLine("{0} {1} - Marks: [{2}]",
                    student.FirstName,
                    student.LastName,
                    string.Join(", ", student.Marks));
            }


        }
    }
}
