using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Contract
    {
        
        public DateTime Contract_StartDate { get; private set; } 
        public DateTime Contract_EndDate { get; private set; } 
        public double Contract_MonthlyAmount { get; private set; } 
        public List<Tenants> Tenants { get; private set; } 
        public List<Property> Property { get; private set; } 
        public List<Document> Document { get; private set; } 
        public List<Receipt> Receipt { get; private set; } 

        // Constructor
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

        // Method to calculate the contract duration in months
        public int GetContractDuration()
        {
            // Calculate the total number of months between start and end dates
            return ((Contract_EndDate.Year - Contract_StartDate.Year) * 12) +
                   (Contract_EndDate.Month - Contract_StartDate.Month);
        }

        // Method to check if the contract is currently valid
        public bool IsValid()
        {
            // A contract is valid if the current date is between the start and end dates
            DateTime currentDate = DateTime.Now;
            return currentDate >= Contract_StartDate && currentDate <= Contract_EndDate;
        }
    }
}
