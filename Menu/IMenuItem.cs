/* IMenuItem.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for the entrees, sides, and drinks
    /// </summary>
    public interface IMenuItem
    {

        /// <summary>
        /// declaration of Price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Declaration of Calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// declaration of Ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
