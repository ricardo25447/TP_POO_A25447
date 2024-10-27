using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Income
    {
        //attributes
        public double IncomeAmountPaid { get; set; }
        public DateTime IncomeDate { get; set; }
        public bool IncomePaymentStatus { get; set; }
        public List<Contract> Contract {get; set; }

        //construtctor
        public Income(double incomeAmountPaid, DateTime incomeDate, bool incomePaymentStatus)
        {
            IncomeAmountPaid = incomeAmountPaid;
            IncomeDate = incomeDate;
            IncomePaymentStatus = incomePaymentStatus;
            Contract = new List<Contract>();
        }

    }
}
