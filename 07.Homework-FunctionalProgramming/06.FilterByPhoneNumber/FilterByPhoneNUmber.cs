using System;
using System.Linq;

namespace StudentsNamespace
{
    internal class FilterByPhoneNumber
    {
        private static void Main()
        {
            var students = StudentsDatabase.GetStudentsList();

            var filterByPhoneNumber = students.Where(p => p.Phone.StartsWith("02")
                                                          || p.Phone.StartsWith("+3592")
                                                          || p.Phone.StartsWith("+359 2"));
            foreach (var student in filterByPhoneNumber)
            {
                Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Phone);
            }

        }
    }
}
