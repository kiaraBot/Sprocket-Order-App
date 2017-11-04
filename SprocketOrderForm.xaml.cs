// Alix Field               afield@cnm.edu              FieldP5_CSharp
// SprocketOrderForm.xaml.cs

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for SprocketOrderForm.xaml
    /// </summary>
    public partial class MessageBox : Window
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        private void cbxLocalPickup_Checked(object sender, RoutedEventArgs e)
        {
            lblStreet.Visibility  = Visibility.Hidden;
            tbxStrAddress.Visibility = Visibility.Hidden;
            lbCity.Visibility = Visibility.Hidden;
            tbxCity.Visibility = Visibility.Hidden;
            lbState.Visibility = Visibility.Hidden;
            tbxState.Visibility = Visibility.Hidden;
            lbZip.Visibility = Visibility.Hidden;
            tbxZip.Visibility = Visibility.Hidden;
        }

        private void cbxLocalPickup_Unchecked(object sender, RoutedEventArgs e)
        {
            lblStreet.Visibility = Visibility.Visible;
            tbxStrAddress.Visibility = Visibility.Visible;
            lbCity.Visibility = Visibility.Visible;
            tbxCity.Visibility = Visibility.Visible;
            lbState.Visibility = Visibility.Visible;
            tbxState.Visibility = Visibility.Visible;
            lbZip.Visibility = Visibility.Visible;
            tbxZip.Visibility = Visibility.Visible;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SprocketForm newSprocket = new SprocketForm();
            newSprocket.ShowDialog();

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
