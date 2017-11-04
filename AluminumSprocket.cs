// Alix Field               afield@cnm.edu              FieldP5_CSharp
// File: AluminumSprocket.cs                _Inherites Sprocket.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldP5_CSharp
{
    public class AluminumSprocket: Sprocket 
    {
        // ----------------------------------------- CONSTUCTORS ------------------------------------------------//

        // Default
        public AluminumSprocket()
        {

        }
        // Overloaded
        public AluminumSprocket(int orderNum, int numItems, int numTeeth) :this()
        {
            NumItems = numItems;
            NumTeeth = numTeeth;
        }


        // ------------------------------------------- CLASS METHODS -------------------------------------------//
        protected override void Calc()
        {
            double tooth = 0.04;
            double price = 0;
            price = NumTeeth * NumItems * tooth;

        }
        public override string ToString()
        {
            return base.ToString() + "Material Type: Aluminum";
        }
    }
}
