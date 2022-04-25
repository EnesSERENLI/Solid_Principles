using DIP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate.Concrete
{
    public class MonsterHunterWorld:IBuy
    {
        public decimal Price { get; set; }
        public string TypeOfGame { get; set; }

        public void BuyGame()
        {
            Console.WriteLine("You bought Moster Hunter World.");
        }
    }
}
