/* MeteorMacAndCheese.cs
 * Author: Branden Bearden
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Side orfer for Meteor Mac and Cheese inheriting Side base class
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Declaring Size enum from Side base class
        /// </summary>
        private Size size;

        /// <summary>
        /// Accessor from Side base class getting and setting price and calories based on size
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
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
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
        }

        /// <summary>
        /// ingredients of Meteor Mac and Cheese
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
                return ingredients;
            }
        }

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Meteor Mac and Cheese";

        }
    }
}
