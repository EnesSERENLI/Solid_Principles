using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Bed
{
    public class DarkSouls
    {
        public decimal Price { get; set; }
        public string TypeOfGame { get; set; }

        public string BuyDs() => "You bought DarkSouls.";
    }
}
