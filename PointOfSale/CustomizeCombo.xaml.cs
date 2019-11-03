/* CustomizeCombo.xaml.cs
 * Author: Branden Bearden
 */

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// opens the entrees screen when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// opens SideSelection page when the side button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Opens DrinkSelection page when the drink button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
