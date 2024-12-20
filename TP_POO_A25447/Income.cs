using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Income : FinancialRecord
    {
        // Specific attribute for Income
        public bool IncomePaymentStatus { get; set; } // Indicates whether the payment has been made

        // List of contracts related to the income
        public List<Contract> Contract { get; set; }

        // Constructor
        public Income(double amount, DateTime date, string description, bool incomePaymentStatus)
            : base(amount, date, description) // Call the constructor of the base class
        {
            IncomePaymentStatus = incomePaymentStatus;
            Contract = new List<Contract>(); // Initialize the list of contracts
        }

        // Override method to display income details
        public override void DisplayRecord()
        {
            base.DisplayRecord(); // Call the base class method
            Console.WriteLine($"Payment Status: {(IncomePaymentStatus ? "Paid" : "Pending")}");
        }
    }
}
