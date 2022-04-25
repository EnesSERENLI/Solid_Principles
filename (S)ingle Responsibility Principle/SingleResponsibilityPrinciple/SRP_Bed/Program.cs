using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Bed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Greeting - Karşılama
            Console.WriteLine("Welcome");

            //Entering information - bilgilerin giriş aşaması
            Book book = new Book();
            Console.WriteLine("Please enter the book name...");
            book.BookName =Console.ReadLine();
            Console.WriteLine("Please enter the authorname...");
            book.AuthorName = Console.ReadLine();
            Console.WriteLine("Please enter the number of pages...");
            book.NumberOfPage = short.Parse(Console.ReadLine());

            //Control - Kontrol aşaması
            if (string.IsNullOrEmpty(book.BookName))
            {
                Console.WriteLine("BookName cannot be blank");
                Console.ReadLine();
                return;
            }
            if (string.IsNullOrEmpty(book.AuthorName))
            {
                Console.WriteLine("AuthorName cannot be blank");
                Console.ReadLine();
                return;
            }

            //Save - Kaydetme
            Console.WriteLine(book.BookName + " saved.");
            Console.Read();
        }
    }
}
