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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger trex;

        public CustomizeTRexKingBurger(TRexKingBurger trex)
        {
            InitializeComponent();
            this.trex = trex;
        }

        /// <summary>
        /// adds hold Whole Wheat bun to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            trex.HoldBun();
        }

        /// <summary>
        /// adds hold Lettuce to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trex.HoldLettuce();
        }

        /// <summary>
        /// adds hold Tomato to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trex.HoldTomato();
        }

        /// <summary>
        /// adds hold Onion to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trex.HoldOnion();
        }

        /// <summary>
        /// adds hold Pickle to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trex.HoldPickle();
        }

        /// <summary>
        /// adds hold Ketchup to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trex.HoldKetchup();
        }

        /// <summary>
        /// adds hold Mustard to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trex.HoldMustard();
        }

        /// <summary>
        /// adds hold Mayo to description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trex.HoldMayo();
        }

        /// <summary>
        /// goes back to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService?.GoBack();
        }
    }
}