using LSP_Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Concrete
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
    }
}
