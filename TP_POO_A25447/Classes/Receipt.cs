using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447.Classes
{
    /// <summary>
    /// Represents a receipt for rental payments or other financial transactions
    /// Contains payment details and associated contract information
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// Gets or sets the unique identifier for the receipt
        /// </summary>
        public int ID_Receipt { get; set; }

        /// <summary>
        /// Gets or sets the list of contracts associated with this receipt
        /// </summary>
        public List<Contract> Contract { get; set; }

        /// <summary>
        /// Gets or sets the date when the receipt was issued
        /// </summary>
        public DateTime Date_Receipt { get; set; }

        /// <summary>
        /// Gets or sets the payment amount recorded on the receipt
        /// </summary>
        public decimal Amount_Receipt { get; set; }

        /// <summary>
        /// Gets or sets additional observations or notes about the receipt
        /// </summary>
        public string OBS_Receipt { get; set; }

        /// <summary>
        /// Initializes a new instance of the Receipt class
        /// </summary>
        /// <param name="Id_Receipt">The unique identifier for the receipt</param>
        /// <param name="date_Receipt">The date when the receipt was issued</param>
        /// <param name="amount_Receipt">The payment amount</param>
        /// <param name="Obs_Receipt">Additional observations or notes</param>
        public Receipt(int Id_Receipt, DateTime date_Receipt, decimal amount_Receipt, string Obs_Receipt)
        {
            ID_Receipt = Id_Receipt;
            Date_Receipt = date_Receipt;
            Amount_Receipt = amount_Receipt;
            OBS_Receipt = Obs_Receipt;
            Contract = new List<Contract>();

        }

    }
}
