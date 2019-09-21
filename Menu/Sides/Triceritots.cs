﻿/* Triceritops.cs
 * Author: Branden Bearden
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Side order for Triceritots inheriting Side base class
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// Declaring Size enum from Side base class
        /// </summary>
        private Size size;

        /// <summary>
        /// Accessor from Side base class getting and setting the price and calories based on the size of the order
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
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
        public Triceritots()
        {
            Price = .99;
            Calories = 352;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");

        }
    }
}
