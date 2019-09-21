/* PterodactylWings.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Menu order for PterodactylWings
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// The price and calories of the wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }
    }
}
