using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Dialer
{
    class Cellphone : Phone
    {
        public Cellphone(string CompanyName, string PhoneNumber, string PhoneType) : base(CompanyName, PhoneNumber, PhoneType)
        {
            
        }
        public override void Dial()
        {
            Console.WriteLine(companyName + " is being dialed using " + "1+" + String.Format("{0: (XXX) XXX-XXXX}", phoneNumber + "..."));
        }
    }
}
