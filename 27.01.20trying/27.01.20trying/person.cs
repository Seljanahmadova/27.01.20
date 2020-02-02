using System;
using System.Collections.Generic;
using System.Text;

namespace _27._01._20trying
{
    class Person
    {
        private static int Id = 0;
        private int _id;
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Id++;
            _id = Id;

        }
        public Person(string name, string surname):this()
        {
            Surname = surname;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}
