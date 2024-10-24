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
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public double MonthlyAmount { get; set; }

        //constructor
        public Contract(DateTime contractStartDate, DateTime contractEndDate, double monthlyAmount)
        {
            ContractStartDate = contractStartDate;
            ContractEndDate = contractEndDate;
            MonthlyAmount = monthlyAmount;
        }
    }
}
