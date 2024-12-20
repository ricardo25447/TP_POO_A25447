using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class FinancialRecord
    {
        // Common attributes for financial records
        public double Amount { get; set; } // Transaction amount
        public DateTime Date { get; set; } // Transaction date
        public string Description { get; set; } // Description of the transaction

        // Constructor to initialize common attributes
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

        // Method to display record details
        public virtual void DisplayRecord()
        {
            Console.WriteLine($"Date: {Date.ToShortDateString()}, Amount: {Amount:C}, Description: {Description}");
        }
    }
}