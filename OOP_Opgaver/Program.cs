using System;

namespace OOP_Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Mike = new Person()
            {
                Name = "Mike",
                Age = 27
            };

            Mike.describePerson();

            Console.ReadLine();
        }
    }
}
