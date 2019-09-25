/* Sodasaurs.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{

   /// <summary>
   /// Customizeable drink order
   /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Declaring size enum
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets the price of the drink based on the size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                }
                else if(size == Size.Medium)
                {
                    Price = 2.00;
                }
                else if(size == Size.Large)
                {
                    Price = 2.50;
                }
            }
        }

       /// <summary>
       /// Declaring the flavor enum
       /// </summary>
        private SodasaurusFlavor flavor;
        
        /// <summary>
        /// Accessor that gets and sets the flavor
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Constructor setting inital drink characteristics
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
        }
    }
}
