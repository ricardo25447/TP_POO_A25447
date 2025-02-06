using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO_A25447.Classes;
using TP_POO_A25447.Models;


namespace TP_POO_A25447.DAL
{
    using TP_POO_A25447.Models;

    public interface ILandlordRepository
    {
        Landlord GetLandlord();
    }
}



