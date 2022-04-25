using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Bed.Interface
{
    public interface IVehicleFeature
    {
        string Start();
        string Stop();
        string Fly();
        string Swimming();
    }
}
