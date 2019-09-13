/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Branden Bearden
 */ 

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Menu order for PrehistoricPBJ
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
        /// Indicates if peanut butter is on the PBJ
        /// </summary>
        private bool PeanutButter = true;
        /// <summary>
        /// Indicates if Jelly is on the PBJ
        /// </summary>
        private bool Jelly = true;

        /// <summary>
        /// Accessor that gets and sets the price of the PBJ
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Accessor that gets and sets teh calories of the PBJ
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List accessor that has set and removeable ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (PeanutButter) ingredients.Add("Peanut Butter");
                if (Jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// The price and caloriies of the PBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Holds the peanut butter if requested
        /// </summary>
        public void HoldPeanutButter()
        {
            this.PeanutButter = false;
        }

        /// <summary>
        /// Holds the jelly if requested
        /// </summary>
        public void HoldJelly()
        {
            this.Jelly = false;
        }
    }
}
