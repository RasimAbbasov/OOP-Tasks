namespace OOP_Task4
{
    public class Book:Product
    {
        public string Genre;
        public Book(string name, decimal price, string genre) : base(name, price)
        {
            Genre = genre;
        }
    }
}
