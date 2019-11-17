/* SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Backing variable for Side
        /// </summary>
        private Side side;

        /// <summary>
        /// Backing variable for CretaceousCombo
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for a new Side
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for editing a side
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        /// <summary>
        /// constructor for selecting a side for a combo
        /// </summary>
        /// <param name="combo"></param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            side = combo.Side;
        }

        /// <summary>
        /// lets you select fryceritops as side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new Fryceritops();
                    order.Add(side);
                }
                else
                {
                    side = new Fryceritops();
                    combo.Side = side;
                }
            }
        }

        /// <summary>
        /// lets you select Meteor Mac and Cheese as side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new MeteorMacAndCheese();
                    order.Add(side);
                }
                else
                {
                    side = new MeteorMacAndCheese();
                    combo.Side = side;
                }
            }
        }

        /// <summary>
        /// lets you select Mezzorella Sticks as side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new MezzorellaSticks();
                    order.Add(side);
                }
                else
                {
                    side = new MezzorellaSticks();
                    combo.Side = side;
                }
            }
        }

        /// <summary>
        /// lets you select Triceritops as side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo == null)
                {
                    side = new Triceritots();
                    order.Add(side);
                }
                else
                {
                    side = new Triceritots();
                    combo.Side = side;
                }
            }
        }

        /// <summary>
        /// lets you change size of the selected side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (side != null)
            {
                if (sender is FrameworkElement element)
                {
                    side.Size = (DDsize)Enum.Parse(typeof(DDsize), element.Tag.ToString());
                    if (combo != null)
                    {
                        NavigationService?.Navigate(new CustomizeCombo(combo));
                    }
                    else NavigationService?.Navigate(new MenuCategorySelection());
                }
            }
        }
    }
}
