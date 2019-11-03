/* Water.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu order for water
    /// </summary>
    public class Water : Drink
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
            set
            {
                size = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// tells if customer wants to add allowable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for water setting price, calories, and ingredients
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Price = .10;
            Calories = 0;
        }

        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Adds lemon if requested
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Water";
        }

        /// <summary>
        /// Gets the description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Tells if there is a special request for the order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
