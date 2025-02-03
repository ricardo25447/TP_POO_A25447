using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447.Classes
{
    public class District
    {
        public int ID_District { get; set; }
        public string OBS_District { get; set; }
        public List<Property> Property { get; set; }

        public District(int Id_District, string Obs_District)
        {
            ID_District = Id_District;
            OBS_District = Obs_District;
            Property = new List<Property>();
        }

    }

}

