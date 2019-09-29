/* Tyrannotea.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Declaring size enum
        /// </summary>
        private Size size;

        /// <summary>
        /// tells if the tea is sweet or not, initially false
        /// </summary>
        public bool Sweetener { get; set; } = false;

        /// <summary>
        /// tells if there is lemon in the drink, initially false
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Sets the price and calories of the drink based on the size and if sweetened
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = .99;
                    if (Sweetener) Calories = 16;
                    else Calories = 8;
                    
                }
                else if (size == Size.Medium)
                {
                    Price = 1.49;
                    if (Sweetener) Calories = 32;
                    else Calories = 16;
                }
                else if (size == Size.Large)
                {
                    Price = 1.99;
                    if (Sweetener) Calories = 64;
                    else Calories = 32;
                }
            }
        }

        /// <summary>
        /// Adds ingredients if requested
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if(Lemon) ingredients.Add("Lemon");
                if(Sweetener) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor setting inital drink characteristics
        /// </summary>
        public Tyrannotea()
        {
            this.Size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        /// <summary>
        /// Adds lemon if requested
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// adds sweetner if requested
        /// </summary>
        public void AddSweetener()
        {
            Sweetener = true;
        }
    }
}
