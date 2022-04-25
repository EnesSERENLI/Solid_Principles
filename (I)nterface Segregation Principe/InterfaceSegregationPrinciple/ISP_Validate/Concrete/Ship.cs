using ISP_Validate.Abstract;
using ISP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Validate.Concrete
{
    public class Ship : Vehicle, IVehicle, IShip
    {
        public string Start()
        {
            return "The ship worked";
        }

        public string Stop()
        {
            return "The ship stopped";
        }

        public string Swimming()
        {
            return "The ship is floating";
        }
    }
}
