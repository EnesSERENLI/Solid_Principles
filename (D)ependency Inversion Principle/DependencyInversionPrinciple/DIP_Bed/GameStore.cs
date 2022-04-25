using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Bed
{
    public class GameStore
    {
        private GodOFWar _gow;
        private DarkSouls _darkSouls;
        private MonsterHunterWorld _monsterHunterWorld;
        public GameStore()
        {
            _gow = new GodOFWar();
            _darkSouls = new DarkSouls();   
            _monsterHunterWorld = new MonsterHunterWorld();
        }

        public void BuyGame()
        {
            _gow.BuyGow();
            _darkSouls.BuyDs();
            _monsterHunterWorld.BuyMhw();
        }
    }
}
