using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    

    public abstract class Drink
    {
        protected List<string> ingredients = new List<string>(); //MAYBE

        /// <summary>
        /// Declares Size enum from Size.cs
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the ingredient list
        /// </summary>
        public virtual List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// tells if there is ice in the drink
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Holds the ice
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }

    }
}
