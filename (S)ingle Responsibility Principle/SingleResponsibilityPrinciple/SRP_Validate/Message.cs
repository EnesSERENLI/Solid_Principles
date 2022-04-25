using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    public class Message
    {
        public static void Greeting() => Console.WriteLine("Welcome!");

        public static void ErrorMEssage(string field) => Console.WriteLine($"{field} cannot be blank!");

    }
}
