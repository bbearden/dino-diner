/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Backing variable for Entree
        /// </summary>
        private Entree entree;

        /// <summary>
        /// Construtor for a new entree
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constuctor to edit already added entree
        /// </summary>
        /// <param name="entree"></param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        /// <summary>
        /// lets you select Brontowurst as the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnBrontowurstSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
            }
            NavigationService?.Navigate(new CustomizeBrontowurst((Brontowurst)entree));
        }

        /// <summary>
        /// lets you select Dino Nuggets as the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDinoNuggetsSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
            }
            NavigationService?.Navigate(new CustomizeDinoNuggets((DinoNuggets)entree));
        }

        /// <summary>
        /// lets you select Prehistoric PB&J as the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPrehistoricPBJSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new CustomizePrehistoricPBJ((PrehistoricPBJ)entree));
            }
            //NavigationService?.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// lets you select Pterodactyl Wings as the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPterodactylWingsSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }
            NavigationService?.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// lets you select Steakosaurus Burger as the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSteakosaurusSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
            }
            NavigationService?.Navigate(new CustomizeSteakosaurusBurger((SteakosaurusBurger)entree));
        }

        /// <summary>
        /// lets you select T-Rex King Burger as the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnTRexKingSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
            }
            NavigationService?.Navigate(new CustomizeTRexKingBurger((TRexKingBurger)entree));
        }

        /// <summary>
        /// lets you select Veloci-Wrap as the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnVelociWrapSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
            }
            NavigationService?.Navigate(new CustomizeVelociWrap((VelociWrap)entree));
        }
    }
}
