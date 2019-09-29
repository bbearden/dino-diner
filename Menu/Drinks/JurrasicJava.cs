using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Declaring size enum
        /// </summary>
        private Size size;

        /// <summary>
        /// tells if the tea is sweet or not
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// tells if there is lemon in the drink, initially false
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Sets the price of the drink based on the size
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
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }

        //Add make decaf class?????????????????
    }
}
