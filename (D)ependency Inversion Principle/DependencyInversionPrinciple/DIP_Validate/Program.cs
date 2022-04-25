using DIP_Validate.Concrete;
using DIP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GodOfWar gow = new GodOfWar();
            gow.Price = 499;
            gow.TypeOfGame = "Story";

            MonsterHunterWorld mhw = new MonsterHunterWorld();
            mhw.Price = 250;
            mhw.TypeOfGame = "Open World";

            List<IBuy> purchases = new List<IBuy>();
            purchases.Add(gow);
            purchases.Add(mhw);

            GameStore gStore = new GameStore(purchases);
            gStore.Buy();

            Console.Read();
        }
    }
}
