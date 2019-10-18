/* Brontowurst.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu order for Brontowurst
    /// </summary>
    public class Brontowurst : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Indicates if the bun is apart of the Brontowurst
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Indicates if peppers are on the Brontowurst
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// Indicates if an onion is on the Brontowurst
        /// </summary>
        private bool Onion = true;

        /// <summary>
        /// An event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// notifys if there was a property value changed
        /// </summary>
        /// <param name="propertyName">name of property changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// List accessor with set and removeable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// The price and calories of the Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
            ingredients.Add("Brautwurst");
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
        /// Holds the peppers if requested
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
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
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
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
                if (!Peppers) special.Add("Hold Peppers");
                if (!Onion) special.Add("Hold Onion");
                return special.ToArray();
            }
        }
    }
}
