/* SteakosaurusBurger.cs
 * Author: Branden Bearden
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{   
    /// <summary>
    /// Menu order for StekosaurusBurger
    /// </summary>
    public class SteakosaurusBurger : Entree
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
        /// List accessor that has set and removeable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
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
            ingredients.Add("Steakburger Pattie");
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

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
