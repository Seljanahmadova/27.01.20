using System;

namespace _27._01._20trying
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("P507");
            //Console.WriteLine(group);
 
            Student s1 = new Student("Sadiq", "Eliyev", 1);
            Student s2 = new Student("Mubariz", "Memmedzade", 1);

            group.AddStudent(s1);
            group.AddStudent(s2);
            //group.ShowAllStudents();
            group.ShowStudentById(3);
        }
    }


   
}
