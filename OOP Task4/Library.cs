using System.ComponentModel.Design;

namespace OOP_Task4
{
    public class Library
    {
        public Book[] Books;
        public int BookCount;
        public Library(int count)
        {
            Books = new Book[count];
            count = 0;
        }
        public void AddBook(Book newbook)
        {
            if (BookCount > Books.Length)
                Console.WriteLine("Kitabxana doludur");
            for (int i = 0; i < BookCount; i++) 
            {
                if (Books[i].Name.Equals(newbook.Name,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Bu kitab movcuddur");
                }
            }
            Books[BookCount] = newbook;
            BookCount++;
        }
        public Book FindBookByName(string bookname)
        {
            for (int i = 0; i < BookCount; i++)
            {
                if (Books[i].Name.Equals(bookname, StringComparison.OrdinalIgnoreCase)) {
                    return Books[i];
                }
            }
            return null;
        }
        public void RemoveBookByName(string name) 
        {
            foreach (var book in Books) 
            {
                if (book.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) 
                {
                    name.Remove(name.Length);
                    Console.WriteLine($"{ book.Name} kitabi kitabxanadan silindi");
                }
            }
        }
           
    }
}
