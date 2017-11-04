// Alix Field               afield@cnm.edu              FieldP5_CSharp
// File: Sprocket.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP5_CSharp
{
    public abstract class Sprocket
    {
        // ----------------------------------------- CONSTUCTORS ------------------------------------------------//

        // Default 
        public Sprocket()
        {

        }

        // Overloaded 
        public Sprocket(int itemID, int numItems, int numTeeth) : this ()
        {
            ItemId = itemID;
            NumItems = numItems;
            NumTeeth = numTeeth;
        }

        // ------------------------------------------- PRIVATE FIELDS -------------------------------------------//

        // Private Field Declerations
        private int numItems;
        private int numTeeth;

        // Fully Qualified Properties
        public int NumItems
        {
            get { return numItems; }
            set { numItems = value; }
        }

        public int NumTeeth
        {
            get { return numTeeth; }
            set { numTeeth = value; }
        }

        // Read Only Auto Property
        public int ItemId { get; private set; }        
        public decimal Price { get; private set; }


        // ------------------------------------------- CLASS METHODS -------------------------------------------//

        protected abstract void Calc();
            

        public override string ToString()
        {
            return "Item Number: " + ItemId + "Number of Items: " + NumItems
                + "Number of Teeth: " + NumTeeth;
        }
    
    }
}
