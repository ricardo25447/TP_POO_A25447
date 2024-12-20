using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    /// <summary>
    /// Represents a document associated with properties and contracts in the system
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Gets or sets the unique identifier for the document
        /// </summary>
        public int ID_Document { get; set; }

        /// <summary>
        /// Gets or sets the name of the document
        /// </summary>
        public string Name_Document { get; set; }

        /// <summary>
        /// Gets or sets the type of document (e.g., receipt, contract, etc.)
        /// </summary>
        public string Type_Document { get; set; }

        /// <summary>
        /// Gets or sets the date when the document was created or issued
        /// </summary>
        public DateTime Date_Document { get; set; }

        /// <summary>
        /// Gets or sets the list of properties associated with this document
        /// </summary>
        public List<Property> Property { get; set; }


        /// <summary>
        /// Initializes a new instance of the Document class
        /// </summary>
        /// <param name="id_Document">The unique identifier for the document</param>
        /// <param name="name_Document">The name of the document</param>
        /// <param name="type_Document">The type of the document</param>
        /// <param name="date_Document">The date of the document</param>
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
