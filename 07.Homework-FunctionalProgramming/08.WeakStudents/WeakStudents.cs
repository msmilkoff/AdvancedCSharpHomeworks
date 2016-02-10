using System;
using System.Linq;

namespace StudentsNamespace
{
    internal class WeakStudents
    {
        private static void Main()
        {
            var students = StudentsDatabase.GetStudentsList();
            var weakStudents = from student in students
                               where student.Marks.Count(p => p == 2) == 2
                               select student;
            foreach (var student in weakStudents)
            {
                Console.WriteLine("{0} {1}, Marks: [{2}]",
                    student.FirstName,
                    student.LastName,
                    string.Join(", ", student.Marks));
            }
        }
    }
}