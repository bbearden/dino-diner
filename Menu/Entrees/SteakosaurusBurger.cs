/* SteakosaurusBurger.cs
 * Author: Branden Bearden
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{   
    /// <summary>
    /// Menu order for StekosaurusBurger
    /// </summary>
    public class SteakosaurusBurger
    {
        /// <summary>
        /// Indicates if the bus is on the burger
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Indicates if pickles are on the burger
        /// </summary>
        private bool Pickle = true;
        /// <summary>
        /// Indicates if ketchup is on the burger
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// Indicates if mustard is on the burger
        /// </summary>
        private bool Mustard = true;

        /// <summary>
        /// Accessor that gets and sets the price of the burger
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Accessor that gets and sets the calories of the burger
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List accessor that has set and removeable ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// The price and calories of the burger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Holds the bun if requested
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }

        /// <summary>
        /// Holds the pickle if requested
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }

        /// <summary>
        /// Holds the ketchup if requested
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }

        /// <summary>
        /// Holds the mustard if requested
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }
    }
}
