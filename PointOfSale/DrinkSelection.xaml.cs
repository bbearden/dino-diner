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
        /// <summary>
        /// variable holding current drink type on the Order list
        /// </summary>
        private Drink drink;

        /// <summary>
        /// sodasaurus instance
        /// </summary>
        Sodasaurus soda = new Sodasaurus();

        /// <summary>
        /// tyrannotea instance
        /// </summary>
        Tyrannotea tea = new Tyrannotea();

        /// <summary>
        /// jurassicjava instance
        /// </summary>
        JurassicJava java = new JurassicJava();

        /// <summary>
        /// water instance
        /// </summary>
        Water water = new Water();

        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            //when chaning size of the selected drink from the order list
            InitializeComponent();
            this.drink = drink;
        }

        /// <summary>
        /// lets you select Sodasaurus as the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            //hides all buttons for when switching from one drink to another
            FlavorButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            LeaveRoomForCreamButton.Visibility = Visibility.Hidden;

            FlavorButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;
            
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                soda = (Sodasaurus) drink; //allows special and description changes
                order.Add(drink);
            }
        }

        /// <summary>
        /// lets you select Tyrannotea as the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTyrannotea(object sender, RoutedEventArgs args)
        {
            FlavorButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            LeaveRoomForCreamButton.Visibility = Visibility.Hidden;

            SweetButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;
            LemonButton.Visibility = Visibility.Visible;

            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                tea = (Tyrannotea)drink; //allows special and description changes
                order.Add(drink);
            }
        }

        /// <summary>
        /// lets you select Jurassic Java as the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            FlavorButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            LeaveRoomForCreamButton.Visibility = Visibility.Hidden;

            DecafButton.Visibility = Visibility.Visible;
            AddIceButton.Visibility = Visibility.Visible;
            LeaveRoomForCreamButton.Visibility = Visibility.Visible;

            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                java = (JurassicJava)drink; //allows special and description changes
                order.Add(drink);
            }
        }

        /// <summary>
        /// lets you select Water as the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            FlavorButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            LeaveRoomForCreamButton.Visibility = Visibility.Hidden;

            LemonButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;

            if (DataContext is Order order)
            {
                drink = new Water();
                water = (Water)drink; //allows special and description changes
                order.Add(drink);
            }
        }



        /// <summary>
        /// Opens FlavorSelection page when the flavor button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection(soda));
        }

        private void OnMakeSweet(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                tea.AddSweetener();
                drink = tea; //allows sweet to be added to order list
            }
        }

        private void OnMakeDecaf(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                java.Decafinate();
                drink = java;
            }
        }

        private void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(drink is Water)
                {
                    water.AddLemon();
                    drink = water;
                }

                if(drink is Tyrannotea)
                {
                    tea.AddLemon();
                    drink = tea;
                }
            }
        }

        private void OnRoomForCream(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                java.LeaveRoomForCream();
                drink = java;
            }
        }

        private void OnHoldIce(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(drink is Sodasaurus)
                {
                    soda.HoldIce();
                    drink = soda;
                }

                if(drink is Tyrannotea)
                {
                    tea.HoldIce();
                    drink = tea;
                }

                if(drink is Water)
                {
                    water.HoldIce();
                    drink = water;
                }
            }
        }

        private void OnAddIce(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                java.AddIce();
                drink = java;
            }
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// lets you change size of the selected side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDsize)Enum.Parse(typeof(DDsize), element.Tag.ToString());
            }
        }
    }
}
