/* VelociWrap.cs
 * Author: Branden Bearden
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{   /// <summary>
    /// Menu order for VelociWrap 
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// Indicates if lettuce is on the wrap 
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// Indicates if dressing is on the wrap
        /// </summary>
        private bool Dressing = true;
        /// <summary>
        /// Indicates if cheese is on the wrap
        /// </summary>
        private bool Cheese = true;

        /// <summary>
        /// Accessor allowing to get or set the price of the wrap
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Accessor allowing to get or set the calories of the wrap
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List accessor that has set and removable ingredients on the wrap
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" , "Chicken Breast" };
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Price and calories of the wrap
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Holds the lettuce if requested
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        /// <summary>
        /// Holds dressing if requested
        /// </summary>
        public void HoldDressing()
        {
            this.Dressing = false;
        }

        /// <summary>
        /// Holds the cheese if requested
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
        }
    }
}
