using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    /// <summary>
    /// Represents a rental contract between tenants and property owners
    /// </summary>
    public class Contract
    {
        /// <summary>
        /// Gets the start date of the contract
        /// </summary>
        public DateTime Contract_StartDate { get; private set; } 

        /// <summary>
        /// Gets the end date of the contract
        /// </summary>
        public DateTime Contract_EndDate { get; private set; } 

        /// <summary>
        /// Gets the monthly rental amount specified in the contract
        /// </summary>
        public double Contract_MonthlyAmount { get; private set; } 

        /// <summary>
        /// Gets the list of tenants associated with this contract
        /// </summary>
        public List<Tenants> Tenants { get; private set; } 

        /// <summary>
        /// Gets the list of properties covered by this contract
        /// </summary>
        public List<Property> Property { get; private set; } 

        /// <summary>
        /// Gets the list of documents related to this contract
        /// </summary>
        public List<Document> Document { get; private set; } 

        /// <summary>
        /// Gets the list of receipts associated with this contract
        /// </summary>
        public List<Receipt> Receipt { get; private set; } 

        /// <summary>
        /// Initializes a new instance of the Contract class
        /// </summary>
        /// <param name="contractStartDate">The start date of the contract</param>
        /// <param name="contractEndDate">The end date of the contract</param>
        /// <param name="monthlyAmount">The monthly rental amount</param>
        /// <exception cref="ArgumentException">Thrown when end date is not after start date or monthly amount is not positive</exception>
        public Contract(DateTime contractStartDate, DateTime contractEndDate, double monthlyAmount)
        {
            // Validate contract dates: End date must be after the start date
            if (contractEndDate <= contractStartDate)
            {
                throw new ArgumentException("The end date must be later than the start date.");
            }

            // Validate monthly amount: It must be greater than zero
            if (monthlyAmount <= 0)
            {
                throw new ArgumentException("The monthly amount must be greater than zero.");
            }

            // Initialize attributes
            Contract_StartDate = contractStartDate;
            Contract_EndDate = contractEndDate;
            Contract_MonthlyAmount = monthlyAmount;

            // Initialize related entity lists
            Tenants = new List<Tenants>();
            Property = new List<Property>();
            Document = new List<Document>();
            Receipt = new List<Receipt>();
        }

        /// <summary>
        /// Calculates the total duration of the contract in months
        /// </summary>
        /// <returns>The number of months between the start and end dates</returns>
        public int GetContractDuration()
        {
            // Calculate the total number of months between start and end dates
            return ((Contract_EndDate.Year - Contract_StartDate.Year) * 12) +
                   (Contract_EndDate.Month - Contract_StartDate.Month);
        }

        /// <summary>
        /// Checks if the contract is currently valid based on the current date
        /// </summary>
        /// <returns>True if the current date is between start and end dates, false otherwise</returns>
        public bool IsValid()
        {
            // A contract is valid if the current date is between the start and end dates
            DateTime currentDate = DateTime.Now;
            return currentDate >= Contract_StartDate && currentDate <= Contract_EndDate;
        }
    }
}
