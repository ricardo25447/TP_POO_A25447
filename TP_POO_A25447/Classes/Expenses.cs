using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447.Classes
{
    /// <summary>
    /// Represents an expense record that inherits from FinancialRecord
    /// Used to track various types of property-related expenses
    /// </summary>
    public class Expenses : FinancialRecord
    {
        /// <summary>
        /// Gets or sets the type or category of the expense (e.g., Maintenance, Taxes, Utilities)
        /// </summary>
        public string TypeOfExpense { get; set; } // Category or type of expense (e.g., Maintenance, Taxes)

        /// <summary>
        /// Gets or sets the list of properties associated with this expense
        /// </summary>
        public List<Property> Property { get; set; }

        /// <summary>
        /// Initializes a new instance of the Expenses class
        /// </summary>
        /// <param name="typeOfExpense">The category or type of the expense</param>
        /// <param name="amount">The monetary amount of the expense</param>
        /// <param name="date">The date when the expense occurred</param>
        /// <param name="description">A detailed description of the expense</param>
        /// <exception cref="ArgumentException">Thrown when typeOfExpense is null or empty</exception>
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

        /// <summary>
        /// Displays the expense record details including the base financial record information
        /// and the specific type of expense
        /// </summary>
        public override void DisplayRecord()
        {
            base.DisplayRecord(); // Call the base class method
            Console.WriteLine($"Type of Expense: {TypeOfExpense}");
        }
    }
}