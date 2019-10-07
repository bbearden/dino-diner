/* JurassicJave.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu order for JurrasicJava (coffee)
    /// </summary>
    public class JurassicJava : Drink
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
        public JurassicJava()
        {
            this.Size = Size.Small;
            Ice = false;
        }

        /// <summary>
        /// ingredients of Jurassic java
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
                return ingredients;
            }
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

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size + " Decaf Jurassic Java";
            }
            else
            {
                return Size + " Jurassic Java";
            }
        }
    }
}
