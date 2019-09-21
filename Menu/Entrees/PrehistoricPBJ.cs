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
    public class PrehistoricPBJ : Entree
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
        /// constructor setting initial price, calories, and List of ingredients from Entree base class
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
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

        /// <summary>
        /// overrides Ingredients List from Entree base class to specify ingredients on order
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (PeanutButter) ingredients.Add("Peanut Butter");
                if (Jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
    }
}
