using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    /// <summary>
    /// Represents an income record that inherits from FinancialRecord
    /// Used to track rental payments and other property-related income
    /// </summary>
    public class Income : FinancialRecord
    {
        /// <summary>
        /// Gets or sets whether the income payment has been received
        /// True indicates payment is complete, False indicates payment is pending
        /// </summary>
        public bool IncomePaymentStatus { get; set; } // Indicates whether the payment has been made

        /// <summary>
        /// Gets or sets the list of contracts associated with this income
        /// </summary>
        public List<Contract> Contract { get; set; }

        /// <summary>
        /// Initializes a new instance of the Income class
        /// </summary>
        /// <param name="amount">The monetary amount of the income</param>
        /// <param name="date">The date when the income was received or recorded</param>
        /// <param name="description">A detailed description of the income</param>
        /// <param name="incomePaymentStatus">The current payment status</param>
        public Income(double amount, DateTime date, string description, bool incomePaymentStatus)
            : base(amount, date, description) // Call the constructor of the base class
        {
            IncomePaymentStatus = incomePaymentStatus;
            Contract = new List<Contract>(); // Initialize the list of contracts
        }

        /// <summary>
        /// Displays the income record details including the base financial record information
        /// and the current payment status
        /// </summary>
        public override void DisplayRecord()
        {
            base.DisplayRecord(); // Call the base class method
            Console.WriteLine($"Payment Status: {(IncomePaymentStatus ? "Paid" : "Pending")}");
        }
    }
}
