using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Tenants
    {
        //attributes
        public string TenantsFullName { get; set; }
        public string TenantsPhone { get; set; }
        public string TenantsCCNumber { get; set; }
        public List<Contract> contracts { get; set; }

        //constructor
        public Tenants(string fullName, string tenantsPhone, string cCNumber)
        {
            TenantsFullName = fullName;
            TenantsPhone = tenantsPhone;
            TenantsCCNumber = cCNumber;
            contracts = new List<Contract>();
        }
    }
}
