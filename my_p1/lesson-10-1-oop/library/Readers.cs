namespace lesson_10_1_oop.library
{
    internal class Readers
    {
        public Reader[] Items;
        public Readers(Reader[] items)
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
