/* DinoNuggets.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Menu order for DinoNuggets
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Accessor that gets and sets the price of the nuggets
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Accessor that gets and sets the calories of the nuggets
        /// </summary>
        public uint Calories { get; set; }
        
        /// <summary>
        /// List accessor that has a minimum of 6 nuggets in the order 
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", };
                return ingredients;
            }
        }

        /// <summary>
        /// The Price and Calories of the nuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
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
