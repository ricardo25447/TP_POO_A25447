﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Parish
    {
        public int ID_Parish { get; set; }
        public string OBS_Parish { get; set; }
        public List<Property> Property { get; set; }

        public Parish(int Id_Parish, string Obs_Municipality)
        {
            this.ID_Parish = Id_Parish;
            this.OBS_Parish = Obs_Municipality;
            Property = new List<Property>();
        }

    }
}
