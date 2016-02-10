using System;
using System.Linq;

namespace StudentsNamespace
{
    class SortStudents
    {
        static void Main()
        {
            var students = StudentsDatabase.GetStudentsList();

            var sortStudents = students
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);
                
            foreach (var student in sortStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

        }
    }
}
