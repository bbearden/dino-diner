/* Side.cs
 * Author: Nathan Bean
 * Modified By: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;
 
namespace DinoDiner.Menu.Sides
{

    /// <summary>
    /// Abstract side class including Price, Calories, Ingredients, and Size
    /// </summary>
    public abstract class Side
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
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
