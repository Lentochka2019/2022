using System;

namespace lesson_10_1_oop.library
{
    internal class Reader : Person
    {
        public Book Book;

        public string DateOfVisit;

        public Reader(string firstName, string lastName, string DateOfVisit, Book book)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfVisit = DateOfVisit;
            this.Book = book;

        }
        public void Print()
        {
            Console.WriteLine($"{this.FirstName} {LastName} {DateOfVisit}: {Book.Name}, {Book.Author}");

        }

    }
}
