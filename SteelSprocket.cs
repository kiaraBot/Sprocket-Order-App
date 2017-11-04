// Alix Field               afield@cnm.edu              FieldP5_CSharp
// File: SteelSprocket.cs                   _Inherits Sprocke.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP5_CSharp
{
    public class SteelSprocket: Sprocket
    {
        // ----------------------------------------- CONSTUCTORS ------------------------------------------------//

        // Default 
        public SteelSprocket() 
        {

        }

        // Overloaded 
        public SteelSprocket(int itemID, int numItems, int numTeeth) : this()
        {
           // ItemID = itemID;
            NumItems = numItems;
            NumTeeth = numTeeth;
        }


        // ------------------------------------------- CLASS METHODS -------------------------------------------//

        protected override void Calc()
        {
            double tooth = 0.05;
            double price = 0;
            price = NumTeeth * NumItems * tooth;                       
        }
        public override string ToString()
        {
            return base.ToString() + "Material Type: Steel";
        }
    }
}
