/* JurrasicJave.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Menu order for JurrasicJava (coffee)
    /// </summary>
    public class JurrasicJava : Drink
    {

        /// <summary>
        /// Declaring size enum
        /// </summary>
        private Size size;

        /// <summary>
        /// tells if there is room for cream, initially false
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// tells if the coffee is decaf, initially false
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Sets the price of the coffee based on the size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = .59;
                    Calories = 2;

                }
                else if (size == Size.Medium)
                {
                    Price = .99;
                    Calories = 4;
                }
                else if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        /// <summary>
        /// Constructor setting inital drink characteristics
        /// </summary>
        public JurrasicJava()
        {
            this.Size = Size.Small;
            Ice = false;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        /// <summary>
        /// Leaves room for cream if requested
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// adds ice if requested
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
