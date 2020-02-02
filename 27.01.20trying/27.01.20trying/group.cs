using System;
using System.Collections.Generic;
using System.Text;

namespace _27._01._20trying
{
    class Group
    {
        private static int _id = 0;
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
        }
        public string Name { get; set; }
        Student[] Students;
        public Group()
        {
            _id++;
            _Id = _id;
            Students = new Student[0];
        }
        public Group(string name):this()
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Group Id: {_Id}\n" +
                $"Group Name: {Name}";
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void ShowAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }
        public void ShowStudentById(int Id)
        {
            bool hasStudent = false;
            foreach (Student student in Students)
            {
                
                if (Id==student.Id)
                {
                    Console.WriteLine(student);
                    hasStudent = true;
                }
              
            }
            if(hasStudent == false)
            {
                Console.WriteLine("bele bir telebe yoxdur");
            }
        }


        public void RemoveStudentById(int Id)
        {

        }
    }

}
