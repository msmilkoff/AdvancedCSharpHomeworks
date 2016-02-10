using System;
using System.Linq;

namespace StudentsNamespace
{
    class StudentsByGroup
    {
        private static void Main()
        {
            var printGroup = StudentsDatabase.GetStudentsList().Where(p => p.GroupNumber == 2)
                .OrderBy(p => p.FirstName);
            foreach (var student in printGroup)
            {
                Console.WriteLine("{0} {1} - Group number: {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
        }
    }
}
