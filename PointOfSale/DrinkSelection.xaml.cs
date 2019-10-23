/* DrinkSelection.xaml.cs
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
using DDsize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;

        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens FlavorSelection page when the falvor button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        /// <summary>
        /// lets you select fryceritops as side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Items.Add(drink);
            }
        }

        /// <summary>
        /// lets you select fryceritops as side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Items.Add(drink);
            }
        }

        /// <summary>
        /// lets you select fryceritops as side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Items.Add(drink);
            }
        }

        /// <summary>
        /// lets you select fryceritops as side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Items.Add(drink);
            }
        }

        /// <summary>
        /// lets you change size of the selected side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSide(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDsize)Enum.Parse(typeof(DDsize), element.Tag.ToString());
            }
        }
    }
}
