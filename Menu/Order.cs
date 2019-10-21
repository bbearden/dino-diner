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
        /// <summary>
        /// items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// calculates the total price from all the items
        /// </summary>
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

        /// <summary>
        /// sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; } = .055;

        /// <summary>
        /// calculates the sles tax based on the price of the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return Math.Round(SalesTaxRate * SubtotalCost,2);
            }
        }

        /// <summary>
        /// the complete total cost of the order including sales tax
        /// </summary>
        public double TotalCost
        {
            get
            {
                return Math.Round(SubtotalCost + SalesTaxCost,2);
            }
        }
    }
}
