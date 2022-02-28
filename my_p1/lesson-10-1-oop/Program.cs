using lesson_10_1_oop.library;

namespace lesson_10_1_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Books");

            var book = new library.Book(new library.Author("Mark", "Twain", "1835-1910"), "The Adventures of Tom Sawyer");
            var otherBook = new library.Book(new library.Author("Mark", "Twain", "1835-1910"), "The Prince and the Pauper");


            Books items = new Books(new Book[]
           {
                book,
                otherBook
           });
            items.Print();
            System.Console.WriteLine("------------------------------------------------------------------------");
            System.Console.WriteLine("Readers");

            var reader1 = new library.Reader("Ivan", "Ivanov", "12.01.2021", book);

            Readers items1 = new Readers(new Reader[]
          {
                reader1
          });
            items1.Print();
        }
    }
}
