using ISP_Validate.Abstract;
using ISP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Validate.Concrete
{
    public class Car : Vehicle, IVehicle
    {
        public string Start()
        {
            return "The car worked";
        }

        public string Stop()
        {
            return "The car stopped";
        }
    }
}
