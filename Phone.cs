using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Dialer
{
    class Phone
    {
        protected string phoneNumber;
        protected string companyName;
        protected string phoneType;
        public Phone(string CompanyName, string PhoneNumber, string PhoneType )
        {
            phoneNumber = PhoneNumber;
            companyName = CompanyName;
            phoneType = PhoneType;
        }
        public virtual void Dial()
        {
           Console.WriteLine(companyName + " is being dialed using " + String.Format("{0:(XXX) XXX-XXXX}", phoneNumber + "..."));
        }
    }

}
