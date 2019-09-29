/* Water.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Menu order for water
    /// </summary>
    public class Water: Drink
    {
        /// <summary>
        /// Declaring size enum
        /// </summary>
        private Size size;

        /// <summary>
        /// tells if there is lemon in the drink, initially false
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// size of the water
        /// </summary>
        public override Size Size
        {
            get { return size; }
        }

        /// <summary>
        /// tells if customer wants to add allowable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for water setting price, calories, and ingredients
        /// </summary>
        public Water()
        {
            Price = .10;
            Calories = 0;
            ingredients.Add("Water");
        }

        /// <summary>
        /// Adds lemon if requested
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

    }
}
