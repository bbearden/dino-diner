/* Order.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        public double SubtotalCost
        {
            get
            {
                double total = 0;

                foreach (IOrderItem item in Items)
                {
                    total += item.Price;
                }

                if (total < 0) total = 0;

                return total;
            }
        }

        public double SalesTaxRate { get; protected set; } = .05;

        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
