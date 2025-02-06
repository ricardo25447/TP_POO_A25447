using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO_A25447.DAL;


namespace TP_POO_A25447.BLL

{
    using TP_POO_A25447.DAL;  // Adicione esta linha no topo do arquivo

    public class AuthService
    {
        private readonly ILandlordRepository _landlordRepository;


        public AuthService(ILandlordRepository landlordRepository)
        {
            _landlordRepository = landlordRepository;

        }

        public bool Authenticate(string username, string password)
        {
            var landlord = _landlordRepository.GetLandlord();
            return landlord != null && landlord.Username == username && landlord.Password == password;

        }
    }
}


