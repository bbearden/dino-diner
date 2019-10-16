/* PterodactylWings.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu order for PterodactylWings
    /// </summary>
    public class PterodactylWings : Entree, INotifyPropertyChanged
    {

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
        /// The price and calories of the wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Ingredients for Pterodactyl Wings
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Gets the description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
    }
}
