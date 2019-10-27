/* FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        Sodasaurus soda = new Sodasaurus();

        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }

        private void Flavor(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                soda.Flavor = (DinoDiner.Menu.SodasaurusFlavor)Enum.Parse(typeof(DinoDiner.Menu.SodasaurusFlavor), element.Tag.ToString());
            }
            NavigationService?.Navigate(new DrinkSelection(soda));     
        }
    }
}
