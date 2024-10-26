using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TP_POO_A25447
{
    public class Property
    {
        //attributes
        public string PropertyAdress { get; set; }
        public string PropertyType { get; set; }
        public double PropertyPrice { get; set; }
        public District ID_District { get; set; }
        public Parish ID_Parish { get; set; }
        public Municipality ID_Municipality { get; set; }
        public List<Expenses> Expenses { get; set; }
        public List<Document> Documents { get; set; }


        //constructor
        public Property(string propertyAdress, string propertyType, double propertyPrice)
        {
            PropertyAdress = propertyAdress;
            PropertyType = propertyType;
            PropertyPrice = propertyPrice;
            Expenses = new List<Expenses>();
            Documents = new List<Document>();


        }

    }
}
