/* DinoNuggets.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;


namespace DinoDiner.Menu
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
        }

        /// <summary>
        /// Ingredients for DinoNuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                ingredients.Add("Chicken Nugget");
                return ingredients;
            }
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

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
