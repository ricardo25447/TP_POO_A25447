using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Document
    {
        public int ID_Document { get; set; }
        public string Name_Document { get; set; }
        public string Type_Document { get; set; } //receipt, etc...
        public DateTime Date_Document { get; set; }
        public Property Property{ get; set; }
    }
}
