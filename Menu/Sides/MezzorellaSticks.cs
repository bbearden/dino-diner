/* MezzorellaSticks.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Side order for Mezzorella Sticks inheriting Side base class
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Declaring Size enum from Side base class
        /// </summary>
        private Size size;

        /// <summary>
        /// Accessor from Size base class getting and setting price and calories based on the size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (Size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructor setting initial price, calories, and ingredients from Side base class
        /// </summary>
        public MezzorellaSticks()
        {
            Price = .99;
            Calories = 540;
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Breading");
            Ingredients.Add("Vegetable Oil");

        }
    }
}
