using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    public class BookControl
    {
        public static bool Control(Book book)
        {
            if (string.IsNullOrEmpty(book.BookName))
            {
                Message.ErrorMEssage("Bookname");
                return false;
            }
            if (string.IsNullOrEmpty(book.AuthorName))
            {
                Message.ErrorMEssage("Authorname");
                return false;
            }
            return true;
        }
    }
}
