// Alix Field               afield@cnm.edu              FieldP5_CSharp
// File: PlasticSprocket.cs                 _Inherits Sprocket.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP5_CSharp
{
    public class PlasticSprocket: Sprocket
    {
        // ----------------------------------------- CONSTUCTORS ------------------------------------------------//
        
        // Default
        public PlasticSprocket()
        {

        }
        // Overloaded
        public PlasticSprocket(int itemID, int numItems, int numTeeth) : this()
        {
            NumItems = numItems;
            NumTeeth = numTeeth;
        }


        // ------------------------------------------- CLASS METHODS -------------------------------------------//
        protected override void Calc()
        {
            double tooth = 0.02;
            double price = 0;
            price = NumTeeth * NumItems * tooth;
        }
        public override string ToString()
        {
            return base.ToString() + "Material Type: Plastic";
        }
    }
}
