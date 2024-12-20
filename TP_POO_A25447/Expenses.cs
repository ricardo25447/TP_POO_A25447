using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Expenses : FinancialRecord
    {
        // Specific attribute for Expenses
        public string TypeOfExpense { get; set; } // Category or type of expense (e.g., Maintenance, Taxes)

        // List of properties related to the expense
        public List<Property> Property { get; set; }

        // Constructor
        public Expenses(string typeOfExpense, double amount, DateTime date, string description)
            : base(amount, date, description) // Call the constructor of the base class
        {
            if (string.IsNullOrWhiteSpace(typeOfExpense))
            {
                throw new ArgumentException("The type of expense cannot be null or empty.");
            }

            TypeOfExpense = typeOfExpense;
            Property = new List<Property>(); // Initialize the list of properties
        }

        // Override method to display expense details
        public override void DisplayRecord()
        {
            base.DisplayRecord(); // Call the base class method
            Console.WriteLine($"Type of Expense: {TypeOfExpense}");
        }
    }
}