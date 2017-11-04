// Alix Field               afield@cnm.edu              FieldP5_CSharp
// File: Address.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP5_CSharp
{
    public class Address
    {
        // -------------------------------------------- PROPERTIES --------------------------------------------------//

        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        // ------------------------------------------ CLASS METHODS ----------------------------------------------//

        public override string ToString()
        {
            return base.ToString();
            // Add Adress or Local Pickup, depending on the user information
        }
    }
}
