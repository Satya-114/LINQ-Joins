using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_CrossJoin
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetAllStudnets()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety"},
                new Student { ID = 2, Name = "Priyanka"},
                new Student { ID = 3, Name = "Anurag"},
                new Student { ID = 4, Name = "Pranaya"},
                new Student { ID = 5, Name = "Hina"}
            };
        }
    }
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public static List<Subject> GetAllSubjects()
        {
            return new List<Subject>()
            {
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 5, SubjectName = "Linq"}
            };
        }
    }
}
