using ISP_Bed.Abstract;
using ISP_Bed.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Bed.Concrete
{
    public class Car : Vehicle, IVehicleFeature
    {
        //Car can't fly
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

        //Car can't swim
        public string Swimming()
        {
            throw new NotImplementedException();
        }
    }
}
