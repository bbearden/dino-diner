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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// backing variable for CretaceousCombo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for a combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }


        /// <summary>
        /// opens SideSelection page when the side button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            if(combo != null)
            {
                NavigationService.Navigate(new SideSelection(combo));
            }
            else NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Opens DrinkSelection page when the drink button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            if(combo != null)
            {
                NavigationService.Navigate(new DrinkSelection(combo));
            }
            else NavigationService.Navigate(new DrinkSelection());
        }
    }
}
