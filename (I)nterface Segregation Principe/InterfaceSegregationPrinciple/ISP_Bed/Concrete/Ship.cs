using ISP_Bed.Abstract;
using ISP_Bed.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Bed.Concrete
{
    public class Ship : Vehicle, IVehicleFeature
    {
        //Ship can't Fly
        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Start()
        {
            return "The car worked";
        }

        public string Stop()
        {
            return "The car stopped";
        }

        public string Swimming()
        {
            return "The ship is floating";
        }
    }
}
