using System;
using System.Collections.Generic;
using System.Text;

namespace _27._01._20trying
{
    class Student
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }

        public Student()
        {
            _id++;
            _Id = _id;
        }
        public Student(string firstname, string lastname, int groupid) : this()
        {
            FirstName = firstname;
            LastName = lastname;
            GroupId = groupid;

        }
        public override string ToString()
        {
            return $"Firstname: {FirstName}\n" +
                $"Lastname: {LastName}\n" +
                $"Group id: {GroupId}";
        }
    }
}
