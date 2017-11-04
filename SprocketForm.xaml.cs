// Alix Field               afield@cnm.edu              FieldP5_CSharp
// SprocketForm.xaml.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FieldP5_CSharp
{
    /// <summary>
    /// Interaction logic for SprocketForm.xaml
    /// </summary>
    public partial class SprocketForm : Window
    {
        // Instantiat Sprocket Objects
        AluminumSprocket alumSproc = new AluminumSprocket(0,0,0);
        PlasticSprocket plastSproc = new PlasticSprocket(0, 0, 0);
        SteelSprocket steeSproc = new SteelSprocket(0, 0, 0);

        // Declare a Sprocket Array
        Sprocket[] sprocketType = new Sprocket [3];
  

        public SprocketForm()
        {
            InitializeComponent();

            // Fill Reference Array w/ Sprocket Objects
            sprocketType[0] = alumSproc;
            sprocketType[1] = plastSproc;
            sprocketType[2] = steeSproc;
        }

        private void btnSubmitItem_Click(object sender, RoutedEventArgs e)
        {

            
            //if ()
          //  {
               // System.Windows.MessageBox.Show("Are you sure you would like to add this item?");
                
          //  }
            else
            {
            
            }
            // Parse TextBox Text to Ints
            int itemId = 0;
            int numItems = 0;
            int numTeeth = 0;
            int.TryParse(tbxItemID.Text, out itemId);
            int.TryParse(tbxNumItem.Text, out numItems);
            int.TryParse(tbxNumTeeth.Text, out numTeeth);

            // CheckBox Logic
            if(cbxItemType.SelectedIndex == 0)
            {
                //alumSproc.OrderNum = itemId;
                alumSproc.NumItems = numItems;
                alumSproc.NumTeeth = numTeeth;
            }
            else if(cbxItemType.SelectedIndex == 1)
            {
                plastSproc.NumItems = numItems;
                plastSproc.NumTeeth = numTeeth;
            }
            else if(cbxItemType.SelectedIndex == 2)
            {
                steeSproc.NumItems = numItems;
                steeSproc.NumTeeth = numTeeth;
            }
        }

        private void btnCancelForm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
