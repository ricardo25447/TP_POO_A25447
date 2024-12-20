using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    public class Property
    {
        // Private attributes for encapsulation
        private string _propertyType; // Stores the type of the property
        private double _propertyPrice; // Stores the price of the property

        // Public property for accessing and setting PropertyType with validation
        public string PropertyType
        {
            get { return _propertyType; }
            set
            {
                // Validation: Ensure the property type is not null or empty
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O tipo de imóvel não ser nulo");
                }
                _propertyType = value;
            }
        }

        // Public property for accessing and setting PropertyPrice with validation
        public double PropertyPrice
        {
            get { return _propertyPrice; }
            set
            {
                // Validation: Ensure the property price is greater than zero
                if (value <= 0)
                {
                    throw new ArgumentException("O preço do imóvel deve ser maior que zero.");
                }
                _propertyPrice = value;
            }
        }

        // Public attributes for related data (kept public for simplicity)
        public List<Income> IncomeAmountPaid { get; set; } // Stores income records related to the property
        public List<District> ID_District { get; set; } // Stores districts associated with the property
        public List<Parish> ID_Parish { get; set; } // Stores parishes associated with the property
        public List<Municipality> ID_Municipality { get; set; } // Stores municipalities associated with the property
        public List<Expenses> Expenses { get; set; } // Stores expense records related to the property
        public List<Document> Documents { get; set; } // Stores documents related to the property

        // Constructor to initialize the Property object
        public Property(string propertyType, double propertyPrice)
        {
            // Use the encapsulated properties to ensure validation
            PropertyType = propertyType;
            PropertyPrice = propertyPrice;

            // Initialize the lists to avoid null references
            IncomeAmountPaid = new List<Income>();
            ID_District = new List<District>();
            ID_Parish = new List<Parish>();
            ID_Municipality = new List<Municipality>();
            Expenses = new List<Expenses>();
            Documents = new List<Document>();
        }
    }
}
