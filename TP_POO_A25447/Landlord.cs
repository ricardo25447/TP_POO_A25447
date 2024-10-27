using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Landlord
    {
        //attributes
        public string LandlordFullName { get; set; }
        public string LandlordPhone { get; set; }
        public string LandlordContracts { get; set; }
        public string LandlordCCNumber { get; set; }
        public List<Property> Properties { get; set; }

        //constructor
        public Landlord(string landlordFullName,string landlordPhone, string landlordContracts, string landlordCCNumber)
        {
            LandlordFullName = landlordFullName;
            LandlordPhone = landlordPhone;
            LandlordContracts = landlordContracts;
            LandlordCCNumber = landlordCCNumber;
            Properties = new List<Property>();
        }
    }
}
