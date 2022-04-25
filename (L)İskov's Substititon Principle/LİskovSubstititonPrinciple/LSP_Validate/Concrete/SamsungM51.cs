using LSP_Validate.Abstract;
using LSP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Concrete
{
    public class SamsungM51 : Phone, IPhoto
    {
        public override string Call()
        {
            return "Making a call";
        }

        public override string SendMessage()
        {
            return "Message is being sent";
        }

        public string TakeAPhoto()
        {
            return "Photo was taken";
        }
    }
}
