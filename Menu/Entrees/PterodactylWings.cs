/* PterodactylWings.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Menu order for PterodactylWings
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Accessor that gets and sets the price of the wings
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Accessor that gets and sets the calories of the wings
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List accesor with the ingredients of the wings
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken","Wing Sauce" };
               
                return ingredients;
            }
        }

        /// <summary>
        /// The price and calories of the wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
