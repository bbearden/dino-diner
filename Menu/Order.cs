/* Order.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// items added to the order
        /// </summary>
        private List<IOrderItem> items;

        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
            
        }

        private double salesTaxRate = 0;

        /// <summary>
        /// calculates the total price from all the items
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double total = 0;

                foreach (IOrderItem item in items)
                {
                    Math.Round(total += item.Price,2);
                }

                if (total < 0) total = 0;

                return Math.Round(total,2);
            }
        }

        /// <summary>
        /// sales tax rate
        /// </summary>
        public double SalesTaxRate {
            get { return salesTaxRate; }
            set
            {
                if (value < 0) return;
                SalesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        /// <summary>
        /// calculates the sles tax based on the price of the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return Math.Round(salesTaxRate * SubtotalCost,2);
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

        /// <summary>
        /// Constructor for Order
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
            
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
             OnCollectionChanged(this, new EventArgs());
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); //adds the nameof the selection to order list
        }
    }
}
