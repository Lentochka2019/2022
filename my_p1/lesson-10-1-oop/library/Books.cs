namespace lesson_10_1_oop.library
{
    internal class Books
    {
        public Book[] Items;
        public Books(Book[] items)
        {
            this.Items = items;
        }
        public void Print()
        {
            foreach (var item in this.Items)
            {
                item.Print();
            }
        }

    }
}
