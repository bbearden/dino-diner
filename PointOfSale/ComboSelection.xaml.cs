/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Backing variable for CretaceousCombo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for ComboSelection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// opens CustomizePrehistoricPBJ when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizePrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo.Entree);
            }
            NavigationService.Navigate(new CustomizePrehistoricPBJ(combo));
        }

        /// <summary>
        /// opens CustomizeBrontowurst when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo.Entree);
            }
            NavigationService.Navigate(new CustomizeBrontowurst(combo));
        }

        /// <summary>
        /// opens CustomizeDinoNuggets when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo.Entree);
            }
            NavigationService.Navigate(new CustomizeDinoNuggets(combo));
        }

        /// <summary>
        /// opens CustomizePterodactylWings when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizePterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo.Entree);
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        /// <summary>
        /// opens CustomizeSteakosaurusBurger when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeSteakosaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo.Entree);
            }
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo));
        }

        /// <summary>
        /// opens CustomizeTRexKingBurger when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeTRexKing(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo.Entree);
            }
            NavigationService.Navigate(new CustomizeTRexKingBurger(combo));
        }

        /// <summary>
        /// opens CustomizeVelociWrap when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomizeVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo.Entree);
            }
            NavigationService.Navigate(new CustomizeVelociWrap(combo));
        }

    }
}
