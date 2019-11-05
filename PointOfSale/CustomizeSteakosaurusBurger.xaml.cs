/* CustomizeSteakosaurusBurger.xaml.cs
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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        /// <summary>
        /// backing variable for SteakosaurusBurger
        /// </summary>
        private SteakosaurusBurger sb;

        /// <summary>
        /// backing variable for CretaceousCombo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for if the Burger is a separate entree
        /// </summary>
        /// <param name="sb"></param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        /// <summary>
        /// Constructor for if the Burger is apart of a combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            sb = (SteakosaurusBurger)combo.Entree;
        }

        /// <summary>
        /// adds hold Whole Wheat bun to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            sb.HoldBun();
        }

        /// <summary>
        /// adds hold Pickle to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            sb.HoldPickle();
        }

        /// <summary>
        /// adds hold Ketchup to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            sb.HoldKetchup();
        }

        /// <summary>
        /// adds hold Mustard to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            sb.HoldMustard();
        }

        /// <summary>
        /// goes back to the page based on if it is in a combo or a separate entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if(combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else NavigationService?.GoBack();
        }
    }
}
