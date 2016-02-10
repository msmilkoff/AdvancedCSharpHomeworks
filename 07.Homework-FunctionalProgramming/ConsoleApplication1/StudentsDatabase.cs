using System.Collections.Generic;

namespace StudentsNamespace
{
    public class StudentsDatabase
    {
        public List<Student> students = new List<Student>();

        public static List<Student> GetStudentsList()
        {
            var students = new List<Student>
            {
                new Student("Todor", "Popov", 50, 801231, "tt@yahoo.com", "02 6123456",
                    new List<int>() {4, 2, 6, 5, 3}, 1),
                new Student("Tonka", "Stancheva", 42, 801242,"mm@abv.bg", "0896123454", 
                    new List<int>() {6, 4, 6, 5, 6}, 2),
                new Student("Stoyan", "Yankov", 15, 801253,"ss@gmail.com", "+3592612342", 
                    new List<int>() {2, 2, 6, 5, 3}, 1),
                new Student("Svetla", "Kirilova", 18, 801214,"ii@outlook.com", "+359 2 6123450", 
                    new List<int>() {4, 2, 3, 5, 3}, 2),
                new Student("Kiril", "Evstatiev", 22, 801275,"kk@gmail.com", "0896123448", 
                    new List<int>() {2, 2, 3, 5, 3}, 3),
                new Student("Kameliya", "Videnova", 50, 801214,"ee@abv.bg", "0896123446", 
                    new List<int>() {4, 4, 4, 5, 3}, 4)
            };

            return students;
        }
    }
}
