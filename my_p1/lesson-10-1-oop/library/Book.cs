using System;

namespace lesson_10_1_oop.library
{
    internal class Book
    {
        public Author Author;
        public string Name;

        public Book(Author author, string name)
        {
            this.Author = author;
            this.Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"{this.Name}, {this.Author.FirstName} {this.Author.LastName} ");

        }
    }
}
