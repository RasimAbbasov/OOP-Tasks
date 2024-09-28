namespace OOP_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Library library = new Library(3);
            Book book1 = new Book("A Hero Born", 20, "Fantasy");
            Book book2 = new Book("The Return of the King", 25, "Fantasy");
            Book book3 = new Book("Gone Girl", 35, "Crime");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            Console.WriteLine($"All books:");
            Console.WriteLine($"{book1.Name}  Price: {book1.Price} Genre: {book1.Genre}");
            Console.WriteLine($"{book2.Name}  Price: {book2.Price} Genre: {book2.Genre}");
            Console.WriteLine($"{book3.Name}  Price: {book3.Price} Genre: {book3.Genre}");
            Book book = library.FindBookByName("Gone Girl");
            if (book != null)
            {
                Console.WriteLine($"Found book Book name: {book.Name}  Price: {book.Price} Genre: {book.Genre}");
            }
            else
                Console.WriteLine("Kitab movcud deyil");
            library.RemoveBookByName("The Return of the King");
            #endregion
            #region Task2
            //Library library1 = new Library(100);
            //int BookCount = 0;

            //do
            //{
            //    Console.WriteLine("1.Kitabi elave et");
            //    Console.WriteLine("2.Kitab sil");
            //    Console.WriteLine("3.Bütün kitablara bax");
            //    Console.WriteLine("4.Secilmiş kitaba bax(ada göre)");
            //    Console.WriteLine("5.Ada göre axtarış et");
            //    Console.WriteLine("6.Cixis");
            //    Console.WriteLine("Secim et:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    switch (a)
            //    {
            //        case 1:
            //            Console.WriteLine("Kitab elave et:");
            //            Book book1 = new Book(Console.ReadLine(), Convert.ToDecimal(Console.ReadLine()), Console.ReadLine());
            //            library1.AddBook(book1);
            //            break;
            //        case 2:
            //            Console.WriteLine("Silinecek kitabin adin daxil et:");
            //            library1.RemoveBookByName(Console.ReadLine());
            //            break;
            //        case 3:
            //            Console.WriteLine("Butun kitablar:");
            //            foreach(var book in library1.Books)
            //                Console.WriteLine($"Kitablar:{book.Name} {book.Price} {book.Genre}");
            //            break;
            //        case 4:
            //            Console.WriteLine("Kitabin adin daxil et:");
            //            library1.FindBookByName(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (true);
            #endregion
        }
    }
}
