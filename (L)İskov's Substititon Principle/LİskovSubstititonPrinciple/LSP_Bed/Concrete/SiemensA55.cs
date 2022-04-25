using LSP_Bed.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Bed.Concrete
{
    public class SiemensA55 : Phone
    {
        public override string Call()
        {
            return "Making a call";
        }

        public override string SendMessage()
        {
            return "Message is being sent";
        }

        //Siemens A55 has no camera ???? 
        public override string TakeAPhoto()
        {
            throw new NotImplementedException();
        }
    }
}
