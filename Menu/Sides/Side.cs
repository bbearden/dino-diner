/* Side.cs
 * Author: Nathan Bean
 * Modified By: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel; 

namespace DinoDiner.Menu
{

    /// <summary>
    /// Abstract side class including Price, Calories, Ingredients, and Size
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// notifys if there was a property value changed
        /// </summary>
        /// <param name="propertyName">name of property changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the description of the order
        /// </summary>
        public abstract string Description { get; }
        
        /// <summary>
        /// Tells if there is a special request for the order
        /// </summary>
        public abstract string[] Special { get; }
    }
}
