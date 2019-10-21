/* Entree.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract Entree class that includes Price, Calories, and Ingredients
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
    {
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
        /// gets the description of the order item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// tells if there is a special request on the order
        /// </summary>
        public abstract string[] Special { get; }
    }
}
