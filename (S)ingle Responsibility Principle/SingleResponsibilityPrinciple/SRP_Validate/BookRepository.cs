using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    public class BookRepository
    {
        public static Book InsertBook()
        {
            Book book = new Book();
            Console.WriteLine("Please enter the book name...");
            book.BookName = Console.ReadLine();
            Console.WriteLine("Please enter the authorname...");
            book.AuthorName = Console.ReadLine();                    
            return book;
        }
    }
}
