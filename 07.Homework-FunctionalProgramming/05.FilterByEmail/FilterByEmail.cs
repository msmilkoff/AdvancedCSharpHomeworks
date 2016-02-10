using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentsNamespace
{
    class FilterByEmail
    {
        static void Main()
        {
            var students = StudentsDatabase.GetStudentsList();
            var filterByEmai = students
                .Where(p => p.Email.Substring(p.Email.Length - 6) == "abv.bg");

            foreach (var student in filterByEmai)
            {
                Console.WriteLine("{0} {1} - email: {2}", student.FirstName
                                                        ,student.LastName
                                                        , student.Email);
            }
        }
    }
}
