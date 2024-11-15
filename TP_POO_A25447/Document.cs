using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        public List<Property> Property { get; set; }


        public Document(int id_Document, string name_Document, string type_Document, DateTime date_Document)
        {
            ID_Document = id_Document;
            Name_Document = name_Document;
            Type_Document = type_Document;
            Date_Document = date_Document;
            Property = new List<Property>();
        }

    }

}
