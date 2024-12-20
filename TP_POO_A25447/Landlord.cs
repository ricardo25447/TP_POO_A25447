using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    /// <summary>
    /// Represents a landlord who owns and manages properties
    /// Contains personal information and associated properties
    /// </summary>
    public class Landlord
    {
        //attributes
        /// <summary>
        /// Gets or sets the full name of the landlord
        /// </summary>
        public string LandlordFullName { get; set; }

        /// <summary>
        /// Gets or sets the contact phone number of the landlord
        /// </summary>
        public string LandlordPhone { get; set; }

        /// <summary>
        /// Gets or sets the contract information associated with the landlord
        /// </summary>
        public string LandlordContracts { get; set; }

        /// <summary>
        /// Gets or sets the citizen card number (CC) of the landlord
        /// Used for identification purposes
        /// </summary>
        public string LandlordCCNumber { get; set; }

        /// <summary>
        /// Gets or sets the list of properties owned by the landlord
        /// </summary>
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Initializes a new instance of the Landlord class
        /// </summary>
        /// <param name="landlordFullName">The full name of the landlord</param>
        /// <param name="landlordPhone">The contact phone number</param>
        /// <param name="landlordContracts">The contract information</param>
        /// <param name="landlordCCNumber">The citizen card number</param>
        public Landlord(string landlordFullName, string landlordPhone, string landlordContracts, string landlordCCNumber)
        {
            LandlordFullName = landlordFullName;
            LandlordPhone = landlordPhone;
            LandlordContracts = landlordContracts;
            LandlordCCNumber = landlordCCNumber;
            Properties = new List<Property>();
        }
    }
}
