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
        public string PropertyType { get; set; }
        public double PropertyPrice { get; set; }
        public List<Income> IncomeAmountPaid { get; set; }
        public List<District> ID_District { get; set; }
        public List<Parish> ID_Parish { get; set; }
        public List<Municipality> ID_Municipality { get; set; }
        public List<Expenses> Expenses { get; set; }
        public List<Document> Documents { get; set; }


        //constructor
        public Property(string propertyType, double propertyPrice)
        {
            PropertyType = propertyType;
            PropertyPrice = propertyPrice;
            ID_District = new List<District>();
            ID_Parish = new List<Parish>();
            ID_Municipality = new List<Municipality>();
            Expenses = new List<Expenses>();
            Documents = new List<Document>();


        }

    }
}
