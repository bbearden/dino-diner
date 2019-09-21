/* DinoNuggets.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Menu order for DinoNuggets
    /// </summary>
    public class DinoNuggets : Entree
    {  
        /// <summary>
        /// The Price and Calories of the nuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
            ingredients.Add("Chicken Nugget");
        }

        /// <summary>
        /// Adds nugget(s) if requested
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.Ingredients.Add("Chicken Nugget");
        }
    }
}
