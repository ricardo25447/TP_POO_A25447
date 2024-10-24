using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Property
    {
        //attributes
        public string PropertyAdress { get; set; }
        public string PropertyType { get; set; }
        public double PropertyPrice { get; set; }

        //constructor
        public Property(string propertyAdress, string propertyType, double propertyPrice)
        {
            PropertyAdress = propertyAdress;
            PropertyType = propertyType;
            PropertyPrice = propertyPrice;
        }

    }
}
