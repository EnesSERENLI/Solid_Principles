using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Greting
            Message.Greeting();
            Console.ReadLine();

            //Entering information
            Book book =BookRepository.InsertBook();

            //Control
            bool stuation = BookControl.Control(book);
            if (stuation == false)
            {
                Console.ReadLine();
                return;
            }
            //Save
            BookGenerator.SaveBook(book);

            Console.Read();

        }
    }
}
