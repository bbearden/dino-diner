/* MainWindow.xaml.cs
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Order order = new Order();
            
            Order order = DataContext as Order; //casting DataContext to Order
            //DataContext = order;
            order.Items.Add(new PrehistoricPBJ());
            order.Items.Add(new Fryceritops());
            order.Items.Add(new Sodasaurus());
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            sb.HoldBun();
            order.Items.Add(sb);
            //DataContext = order; we declared it in xaml

            
        }

        private void PassDataContentToPage()
        {
            if(OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }
    }
}
