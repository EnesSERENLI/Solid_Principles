using LSP_Bed.Abstract;
using LSP_Bed.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Bed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone iphone = new Iphone(); //No error
            Phone samsung = new SamsungM51();
            Phone siemens = new SiemensA55();


            Console.WriteLine(siemens.TakeAPhoto()); //Will throw an error.. Because siemensA55 has no camera
        }
    }
}
