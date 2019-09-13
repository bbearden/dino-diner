/* Brontowurst.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Menu order for Brontowurst
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// Indicates if the bun is apart of the Brontowurst
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Indicates if peppers are on the Brontowurst
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// Indicates if an onion is on the Brontowurst
        /// </summary>
        private bool Onion = true;

        /// <summary>
        /// Accessor that gets and sets the price of the Brontowurst
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Accessor that gets and sets the calories of the Brontowurst
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List accessor with set and removeable ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// The price and calories of the Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Holds the bun if requested
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }

        /// <summary>
        /// Holds the peppers if requested
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
        }

        /// <summary>
        /// Holds the onion if requested
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
        }
    }
}
