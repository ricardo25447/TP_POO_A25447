using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447.Classes
{
    /// <summary>
    /// Base class for all financial transactions in the system
    /// Provides common functionality for both income and expense records
    /// </summary>
    public class FinancialRecord
    {
        /// <summary>
        /// Gets or sets the monetary amount of the transaction
        /// </summary>
        public double Amount { get; set; } // Transaction amount
        /// <summary>
        /// Gets or sets the date when the transaction occurred
        /// </summary>
        public DateTime Date { get; set; } // Transaction date
        /// <summary>
        /// Gets or sets a detailed description of the transaction
        /// </summary>
        public string Description { get; set; } // Description of the transaction

        /// <summary>
        /// Initializes a new instance of the FinancialRecord class
        /// </summary>
        /// <param name="amount">The monetary amount of the transaction</param>
        /// <param name="date">The date of the transaction</param>
        /// <param name="description">A detailed description of the transaction</param>
        /// <exception cref="ArgumentException">Thrown when amount is less than or equal to zero</exception>
        public FinancialRecord(double amount, DateTime date, string description)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The transaction amount must be greater than zero.");
            }

            Amount = amount;
            Date = date;
            Description = description;
        }

        /// <summary>
        /// Displays the details of the financial record in a formatted string
        /// Can be overridden by derived classes to add specific display information
        /// </summary>
        public virtual void DisplayRecord()
        {
            Console.WriteLine($"Date: {Date.ToShortDateString()}, Amount: {Amount:C}, Description: {Description}");
        }
    }
}