using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Contract
    {
        //attributes
        public DateTime Contract_StartDate { get; set; }
        public DateTime Contract_EndDate { get; set; }
        public double Contract_MonthlyAmount { get; set; }
        public List<Tenants> Tenants { get; set; }
        public List<Property> Property { get; set; }
        public List<Document> Document { get; set; }
        public List <Receipt> Receipt { get; set; }    

        //constructor
        public Contract(DateTime contractStartDate, DateTime contractEndDate, double monthlyAmount)
        {
            Contract_StartDate = contractStartDate;
            Contract_EndDate = contractEndDate;
            Contract_MonthlyAmount = monthlyAmount;
            Tenants = new List<Tenants>();
            Property = new List<Property>();
            Document = new List<Document>();
            Receipt = new List<Receipt>();

        }
     }
}
