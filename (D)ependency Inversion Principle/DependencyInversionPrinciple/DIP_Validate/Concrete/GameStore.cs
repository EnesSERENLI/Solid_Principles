using DIP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate.Concrete
{
    public class GameStore
    {
        private List<IBuy> _purchases;
        public GameStore(List<IBuy> purchases)
        {
            _purchases = purchases;
        }

        public void Buy()
        {
            foreach (IBuy purchase in _purchases)
            {
                purchase.BuyGame();
            }            
        }
    }
}
