using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Receipt
    {
        public int ID_Receipt { get; set; }
        public List<Contract> Contract { get; set; }
        public DateTime Date_Receipt { get; set; }
        public decimal Amount_Receipt { get; set; }
        public string OBS_Receipt { get; set; }

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
