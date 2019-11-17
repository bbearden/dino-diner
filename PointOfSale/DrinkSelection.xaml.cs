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
        public Drink drink { get; set; }

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

        /// <summary>
        /// Backing variable for CretaceousCombo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for opening the DrinkSelection page
        /// </summary>
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
        /// Constructor for if the drink is going to be apart of a combo
        /// </summary>
        /// <param name="combo"></param>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            drink = combo.Drink;
            FlavorButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            LeaveRoomForCreamButton.Visibility = Visibility.Hidden;
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
                if (combo == null)
                {
                    drink = new Sodasaurus();
                    soda = (Sodasaurus)drink; //allows special and description changes
                    order.Add(drink);
                }
                else
                {
                    drink = new Sodasaurus();
                    soda = (Sodasaurus)drink;
                    combo.Drink = drink;
                }
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
                if (combo == null)
                {
                    drink = new Tyrannotea();
                    tea = (Tyrannotea)drink; //allows special and description changes
                    order.Add(drink);
                }
                else
                {
                    drink = new Tyrannotea();
                    tea = (Tyrannotea)drink;
                    combo.Drink = drink;
                }
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
                if (combo == null)
                {
                    drink = new JurassicJava();
                    java = (JurassicJava)drink; //allows special and description changes
                    order.Add(drink);
                }
                else
                {
                    drink = new JurassicJava();
                    java = (JurassicJava)drink;
                    combo.Drink = drink;

                }
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
                if (combo == null)
                {
                    drink = new Water();
                    water = (Water)drink; //allows special and description changes
                    order.Add(drink);
                }
                else
                {
                    drink = new Water();
                    water = (Water)drink;
                    combo.Drink = drink;
                }
            }
        }

        /// <summary>
        /// Opens FlavorSelection page when the flavor button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                NavigationService.Navigate(new FlavorSelection(soda));
            }
            else
            {
                NavigationService.Navigate(new FlavorSelection(combo));
            }
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
                tea = (Tyrannotea)drink; //allows sweet to be added
                tea.AddSweetener();
                //drink = tea; was how sweet was originally added
                if (combo != null)
                {
                    combo.Drink = tea;
                }
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
                java = (JurassicJava)drink;
                java.Decafinate();
                if (combo != null)
                {
                    combo.Drink = java;
                }
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
                    water = (Water)drink;
                    water.AddLemon();
                    if (combo != null)
                    {
                        combo.Drink = water;
                    }
                }

                if(drink is Tyrannotea)
                {
                    tea = (Tyrannotea)drink;
                    tea.AddLemon();
                    if (combo != null)
                    {
                        combo.Drink = tea;
                    }
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
                java = (JurassicJava)drink;
                java.LeaveRoomForCream();
                if (combo != null)
                {
                    combo.Drink = java;
                }
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
                    soda = (Sodasaurus)drink;
                    soda.HoldIce();
                    if(combo != null)
                    {
                        combo.Drink = soda;
                    }
                }

                if(drink is Tyrannotea)
                {
                    tea = (Tyrannotea)drink;
                    tea.HoldIce();
                    if (combo != null)
                    {
                        combo.Drink = tea;
                    }
                }

                if(drink is Water)
                {
                    water = (Water)drink;
                    water.HoldIce();
                    if (combo != null)
                    {
                        combo.Drink = water;
                    }
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
                java = (JurassicJava)drink;
                java.AddIce();
                if(combo != null)
                {
                    combo.Drink = java;
                }
            }
        }

        /// <summary>
        /// returns to the menu category selection screen when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if(combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else NavigationService?.Navigate(new MenuCategorySelection());
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
                if (combo == null)
                {
                    drink.Size = (DDsize)Enum.Parse(typeof(DDsize), element.Tag.ToString());
                }
            }
            
        }

        /// <summary>
        /// Only shows buttons relating to sodasaurus
        /// </summary>
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

        /// <summary>
        /// Only shows buttons relating to Tyrannotea
        /// </summary>
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

        /// <summary>
        /// Ojnly shows buttons relating to JurassicJ
        /// </summary>
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

        /// <summary>
        /// Only shows buttons relating to Water
        /// </summary>
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
