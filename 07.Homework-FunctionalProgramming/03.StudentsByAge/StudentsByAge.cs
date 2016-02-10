using System;
using System.Linq;

namespace StudentsNamespace
{
    class StudentsByAge
    {
        static void Main()
        {
            var students = StudentsDatabase.GetStudentsList();

            var studentsByAge = students.Where(p => (p.Age >= 18 && p.Age <= 24));
            foreach (var student in studentsByAge)
            {
                Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
