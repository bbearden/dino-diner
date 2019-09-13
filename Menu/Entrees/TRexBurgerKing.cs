/* TRexBurgerKing.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Menu order for TRExBurgerKing
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// Indicates if the bun is on the burger
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Indicates if lettuce is on the burger
        /// </summary>
        private bool Lettcue = true;
        /// <summary>
        /// Indicates if a tomato is on the burger
        /// </summary>
        private bool Tomato = true;
        /// <summary>
        /// Indicates if an onion is on the burger
        /// </summary>
        private bool Onion = true;
        /// <summary>
        /// indicates if a pickle is on the burger
        /// </summary>
        private bool Pickle = true;
        /// <summary>
        /// Indicates if ketchup is on the burger
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// Indicates if mustard is on the burger
        /// </summary>
        private bool Mustard = true;
        /// <summary>
        /// Indicates if mayo is on the burger
        /// </summary>
        private bool Mayo = true;

        /// <summary>
        /// Accessor that gets and sets the price of the burger
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Accessor that gets and sets the price of the burger
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// List accessor of strings that has set and removeable ingresients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" , "Steakburger Pattie" , "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettcue) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Onion) ingredients.Add("Onion");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// The price and callories of the wrap
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Holds the bun if requested
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }

        /// <summary>
        /// Holds the lettuce if requested
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettcue = false;
        }

        /// <summary>
        /// Holds the tomato if requested
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
        }

        /// <summary>
        /// Holds the onion if requested
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
        }

        /// <summary>
        /// Holds the pickle if requested
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }

        /// <summary>
        /// Holds the ketchupo if requested
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }

        /// <summary>
        /// Holds mustard if requested
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }

        /// <summary>
        /// Holds the mayo if requested
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
        }
    }
}
