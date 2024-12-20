using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    /// <summary>
    /// Represents a tenant who rents properties
    /// Contains personal information and associated rental contracts
    /// </summary>
    public class Tenants
    {
        //attributes
        /// <summary>
        /// Gets or sets the full name of the tenant
        /// </summary>
        public string TenantsFullName { get; set; }

        /// <summary>
        /// Gets or sets the contact phone number of the tenant
        /// </summary>
        public string TenantsPhone { get; set; }

        /// <summary>
        /// Gets or sets the citizen card number (CC) of the tenant
        /// Used for identification purposes
        /// </summary>
        public string TenantsCCNumber { get; set; }

        /// <summary>
        /// Gets or sets the list of rental contracts associated with this tenant
        /// </summary>
        public List<Contract> contracts { get; set; }

        /// <summary>
        /// Initializes a new instance of the Tenants class
        /// </summary>
        /// <param name="fullName">The full name of the tenant</param>
        /// <param name="tenantsPhone">The contact phone number</param>
        /// <param name="cCNumber">The citizen card number</param>
        public Tenants(string fullName, string tenantsPhone, string cCNumber)
        {
            TenantsFullName = fullName;
            TenantsPhone = tenantsPhone;
            TenantsCCNumber = cCNumber;
            contracts = new List<Contract>();
        }
    }
}
