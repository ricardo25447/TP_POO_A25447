﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447.Classes
{
    public class Municipality
    {
        public int ID_Municipality { get; set; }
        public string OBS_Municipality { get; set; }
        public List<Property> Property { get; set; }

        public Municipality(int Id_Municipality, string Obs_Municipality)
        {
            ID_Municipality = Id_Municipality;
            OBS_Municipality = Obs_Municipality;
            Property = new List<Property>();
        }

    }
}
