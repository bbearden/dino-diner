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
        private Sodasaurus soda; //Sodasaurus soda = new Sodasaurus() works too because the default is private

        /// <summary>
        /// tyrannotea instance
        /// </summary>
        private Tyrannotea tea;

        /// <summary>
        /// jurassicjava instance
        /// </summary>
        private JurassicJava java;

        /// <summary>
        /// water instance
        /// </summary>
        private Water water;

        public DrinkSelection()
        {
            InitializeComponent();
            FlavorButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            LeaveRoomForCreamButton.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// constructor for changing the size of a drink
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            if (drink is Sodasaurus) SodasaurusVisibility();
            if (drink is Tyrannotea) TyrannoteaVisibility();
            if (drink is JurassicJava) JurassicJavaVisibility();
            if (drink is Water) WaterVisibility();
            
        }

        /// <summary>
        /// lets you select Sodasaurus as the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            //hides all buttons for when switching from one drink to another
            SodasaurusVisibility();

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
            TyrannoteaVisibility();

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
            JurassicJavaVisibility();

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
            WaterVisibility();

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

        /// <summary>
        /// adds sweet to special property of the tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMakeSweet(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                tea.AddSweetener();
                drink = tea; //allows sweet to be added to order list
            }
        }

        /// <summary>
        /// adds decaf to special property of the jurassic java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMakeDecaf(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                java.Decafinate();
                drink = java;
            }
        }

        /// <summary>
        /// adds lemon to the description of the specified drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

        /// <summary>
        /// adds room for cream to the description of the jurassic java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRoomForCream(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                java.LeaveRoomForCream();
                drink = java;
            }
        }

        /// <summary>
        /// adds hold ice to the description of the specified drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

        /// <summary>
        /// adds add ice to the the description of the jurassic java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddIce(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                java.AddIce();
                drink = java;
            }
        }

        /// <summary>
        /// returns to the menu category selection screen when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

        void SodasaurusVisibility()
        {
            FlavorButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            LeaveRoomForCreamButton.Visibility = Visibility.Hidden;

            FlavorButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;
        }

        void TyrannoteaVisibility()
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
        }

        void JurassicJavaVisibility()
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
        }

        void WaterVisibility()
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
        }
    }
}
