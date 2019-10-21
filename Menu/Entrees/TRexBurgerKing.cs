/* TRexBurgerKing.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu order for TRExBurgerKing
    /// </summary>
    public class TRexKingBurger : Entree
    {

        /// <summary>
        /// Indicates if the bun is on the burger
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Indicates if lettuce is on the burger
        /// </summary>
        private bool Lettuce = true;
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
        /// List accessor of strings that has set and removeable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
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
            Price = 8.45;
            Calories = 728;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
        }

        /// <summary>
        /// Holds the bun if requested
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the lettuce if requested
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the tomato if requested
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the onion if requested
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the pickle if requested
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the ketchupo if requested
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds mustard if requested
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the mayo if requested
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!Bun) special.Add("Hold Whole Wheat Bun");
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Tomato) special.Add("Hold Tomato");
                if (!Onion) special.Add("Hold Onion");
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                if (!Mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
    }
}
