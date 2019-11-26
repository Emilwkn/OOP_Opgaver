using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Opgaver
{
    class Person
    {
        private string name;
        private int age;
        private DateTime birhtday;

        public void describePerson()
        {
            Console.WriteLine($"{name} is {age} years old.");
        }

        public Person()
            : this("no name", 0) { }

        public Person(string name, int age)
        {
            name = Name;
            age = Age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
