﻿/* Fryceritops.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Side order for Fryceritops inheriting Side base class
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Declaring Size enum from Size base class
        /// </summary>
        private Size size;

        /// <summary>
        /// Accessor from Side base class getting and setting the price and calories based on the size
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Constructor setting initial price, calories, and ingredients from Side base class
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
        }

        /// <summary>
        /// Ingredients for Fryceritops
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Fryceritops";

        }

        /// <summary>
        /// Gets the description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Tells if there is a special request for the order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
