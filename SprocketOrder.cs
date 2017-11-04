// Alix Field               afield@cnm.edu              FieldP5_CSharp
// SprocketOrder.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP5_CSharp
{
    public class SprocketOrder
    {
        // ---------------------------------------- PRIVATE FIELDS ------------------------------------------------//
        private List<Sprocket> items = new List<Sprocket>();

        // ------------------------------------------- CONSTUCTORS ----------------------------------------------//

        // Default
        public SprocketOrder()
        {

        }

        // Overloaded
        public SprocketOrder(Address address, string customerName, List<Sprocket> items)
        {
            Address = address;
            CustomerName = customerName;
            Items = items;
        }


        // ------------------------------------------ PROPERTIES --------------------------------------------------//

        public List<Sprocket> Items
        {
            get { return Items; }
            set { Items = value; }
        }

        public Address Address { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; set; }

        // ------------------------------------------- CLASS METHODS ------------------------------------------------//

        // Add Items to User List
        public void Add()
        {
            //AluminumSprocket alumSproc = new AluminumSprocket();
            //PlasticSprocket plastSproc = new PlasticSprocket();
            //SteelSprocket steeSproc = new SteelSprocket();
            //items.Add(alumSproc);
            //items.Add(steeSproc);
            //items.Add(plastSproc);
        }

        // Remove Items from User List
        public void Remove()
        {

        }

        // Combined Price of all User Items
        public void Calc()
        {

        }

        public override string ToString()
        {
            return base.ToString();  
            // Returns customer name, count of items in the order, total price, and address
            // If address is null it should say "Local Pickup"
        }

    }
}
