using ISP_Validate.Abstract;
using ISP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Validate.Concrete
{
    public class Aerplane : Vehicle, IVehicle, IAerplane
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
            return "The plane stopped";
        }
    }
}
