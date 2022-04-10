using System;
using Task_3.Models;

namespace Task_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Ilkin";
            student1.SurName = "Ibrahimov";

            Student student2 = new Student();
            student2.Name = "Orxan";
            student2.SurName = "Qenberov";


            Student student3 = new Student();
            student3.Name = "Tural";
            student3.SurName = "Memmedzade";


            Group group = new Group();
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            foreach (Student student in group.students)
            {
                Console.WriteLine(student.Name+" "+student.SurName);
            }


            //string[] arr = { "ilkin", "orxan", "tural" };
            //string newElement = "eyyub";
            //Array.Resize(ref arr, arr.Length + 1);
            //arr[arr.Length - 1] = newElement;
            //foreach (var e in arr)
            //{
            //    Console.WriteLine(e);
            //}
        }
    }
}
