/* Tyrannotea.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu order for Tyrannotea
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Declaring size enum
        /// </summary>
        private Size size;

        private bool sweet;

        /// <summary>
        /// tells if the tea is sweet or not, initially false
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                NotifyOfPropertyChanged("Description");
            }
        }
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
                    if (Sweet) Calories = 16;
                    else Calories = 8;
                    
                }
                else if (size == Size.Medium)
                {
                    Price = 1.49;
                    if (Sweet) Calories = 32;
                    else Calories = 16;
                }
                else if (size == Size.Large)
                {
                    Price = 1.99;
                    if (Sweet) Calories = 64;
                    else Calories = 32;
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Ingredients for Tyrannotea
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if(Lemon) ingredients.Add("Lemon");
                if(Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor setting inital drink characteristics
        /// </summary>
        public Tyrannotea()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// Holds the ice
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Adds lemon if requested
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// adds sweetner if requested
        /// </summary>
        public void AddSweetener()
        {
            Sweet = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return Size + " Sweet Tyrannotea";
            }
            else
            {
                return Size + " Tyrannotea";
            }
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
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
