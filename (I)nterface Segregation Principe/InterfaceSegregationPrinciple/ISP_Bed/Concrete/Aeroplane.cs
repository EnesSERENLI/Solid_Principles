using ISP_Bed.Abstract;
using ISP_Bed.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Bed.Concrete
{
    public class Aeroplane : Vehicle, IVehicleFeature
    {
        public string Fly()
        {
            return "Airplane flying";
        }

        public string Start()
        {
            return "The plane worked";
        }

        public string Stop()
        {
            return "The plan stopped";
        }
        //Aerplane can't swim
        public string Swimming()
        {
            throw new NotImplementedException();
        }
    }
}
