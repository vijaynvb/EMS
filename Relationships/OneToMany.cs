using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> students { get; set; }
    } 

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Faculty Faculty { get; set; }
    }

    internal class OneToMany
    {
        public static void Main()
        {
            Student student = new Student();
            student.Name = "abc";
            Student student1 = new Student();
            Student student2 = new Student();
            student1.Name = "pqr";
            student2.Name = "xyz";

            Faculty faculty = new Faculty();
            faculty.Name = "vijay";
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student);
            faculty.students = students;
        }
    }
}
