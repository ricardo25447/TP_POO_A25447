using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_A25447
{
    /// <summary>
    /// Represents a real estate property with its characteristics and associated data
    /// </summary>
    public class Property
    {
        // Private fields for encapsulation
        private string _propertyType; // Type of the property (e.g., apartment, house)
        private double _propertyPrice; // Price of the property in the current currency

        /// <summary>
        /// Gets or sets the type of the property
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when property type is null or empty</exception>
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

        /// <summary>
        /// Gets or sets the price of the property
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when property price is less than or equal to zero</exception>
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

        // Associated data collections
        /// <summary>
        /// List of income records associated with this property
        /// </summary>
        public List<Income> IncomeAmountPaid { get; set; }

        /// <summary>
        /// List of districts where the property is located
        /// </summary>
        public List<District> ID_District { get; set; }

        /// <summary>
        /// List of parishes where the property is located
        /// </summary>
        public List<Parish> ID_Parish { get; set; }

        /// <summary>
        /// List of municipalities where the property is located
        /// </summary>
        public List<Municipality> ID_Municipality { get; set; }

        /// <summary>
        /// List of expenses associated with this property
        /// </summary>
        public List<Expenses> Expenses { get; set; }

        /// <summary>
        /// List of documents related to this property
        /// </summary>
        public List<Document> Documents { get; set; }

        /// <summary>
        /// Initializes a new instance of the Property class
        /// </summary>
        /// <param name="propertyType">The type of the property</param>
        /// <param name="propertyPrice">The price of the property</param>
        /// <exception cref="ArgumentException">Thrown when input parameters are invalid</exception>
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
