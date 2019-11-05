/* CustomizeVelociWrap.xaml.cs
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// Backing varaiable for velociwrap
        /// </summary>
        private VelociWrap vw;

        /// <summary>
        /// Backing variable for CretaceousCombo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for if the wrap is a separate entree
        /// </summary>
        /// <param name="vw"></param>
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        /// <summary>
        /// Constructor for if the wrap is apart of a combo
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeVelociWrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            vw = (VelociWrap)combo.Entree;
        }

        /// <summary>
        /// adds hold Romaine lettuce to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            vw.HoldLettuce();
        }

        /// <summary>
        /// adds hold Caesar Dressing to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            vw.HoldDressing();
        }

        /// <summary>
        /// adds hold Parmesan Cheese to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            vw.HoldCheese();
        }

        /// <summary>
        /// goes back to the page based on if it is in a combo or separate entree
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
