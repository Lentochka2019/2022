using System;

namespace lesson_10_1_oop.library
{
    internal class Author : Person
    {
        public string Years;

        public Author(string firstName, string lastName, string years)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Years = years;
        }
        public void Print()
        {
            Console.WriteLine($"{this.FirstName} {LastName} ({Years})");

        }

    }


}
