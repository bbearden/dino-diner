/* VelociWrap.cs
 * Author: Branden Bearden
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{   /// <summary>
    /// Menu order for VelociWrap 
    /// </summary>
    public class VelociWrap : Entree
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
        /// Constructor setting initial price, calories, and List of ingredients from Entree base class
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            
        }

        /// <summary>
        /// Overrides Ingredients List from Entree base c
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if(Lettuce) ingredients.Add("Romaine Lettuce");
                if(Dressing) ingredients.Add("Ceasar Dressing");
                if(Cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
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
