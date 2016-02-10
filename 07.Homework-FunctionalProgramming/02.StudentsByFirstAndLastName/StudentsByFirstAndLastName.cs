using System;
using System.Linq;

namespace StudentsNamespace
{

    class StudentsByFirstAndLastName
    {
        static void Main()
        {
            var students = StudentsDatabase.GetStudentsList();
            var studentsByName = students.Where(p => (p.FirstName.CompareTo(p.LastName) < 0));
                
            foreach (var student in studentsByName)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
