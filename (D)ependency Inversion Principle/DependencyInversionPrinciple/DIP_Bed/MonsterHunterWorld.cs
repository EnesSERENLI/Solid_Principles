using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Bed
{
    public class MonsterHunterWorld
    {
        public decimal Price { get; set; }
        public string TypeOfGame { get; set; }

        public string BuyMhw() => "You bought Monster Hunter World.";
    }
}
