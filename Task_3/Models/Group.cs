using System;
using System.Linq;

namespace Task_3.Models
{
    public class Group
    {
        public Student[] students= new Student[0];

        public int GroupNo { get; set; }

        //public void AddStudent(string fullName)
        //{
        //    Array.Resize(ref students,students.Length + 1);
        //    students[students.Length - 1] = fullName;
        //}
        public void AddStudent(Student student)
        {

            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
    }
           
}
