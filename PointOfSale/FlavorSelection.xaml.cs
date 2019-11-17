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
        /// <summary>
        /// the drink that is having flavor added to it
        /// </summary>
        private Sodasaurus soda = new Sodasaurus();

        private CretaceousCombo combo;

        /// <summary>
        /// FlavorSelection constructor when the drink is not in a combo
        /// </summary>
        /// <param name="soda"></param>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }

        /// <summary>
        /// FlavorSelection constructor is the soda is in a combo
        /// </summary>
        /// <param name="combo"></param>
        public FlavorSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Lets you change the flavor of your soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Flavor(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                soda.Flavor = (DinoDiner.Menu.SodasaurusFlavor)Enum.Parse(typeof(DinoDiner.Menu.SodasaurusFlavor), element.Tag.ToString());
                if(combo != null)
                {
                    combo.Drink = soda;
                }
            }
            NavigationService.GoBack();     
        }
    }
}
