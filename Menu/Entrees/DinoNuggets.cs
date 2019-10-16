/* DinoNuggets.cs
 * Author: Branden Bearden
 */ 

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu order for DinoNuggets
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// the amount of nuggets in the order
        /// </summary>
        private int nuggetCount = 6;

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
        /// The Price and Calories of the nuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6; 
        }

        /// <summary>
        /// Ingredients for DinoNuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            { 
                List<string> ingredients = new List<string>();
                for(int i = 0; i<nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Adds nugget(s) if requested
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.nuggetCount += 1;
            //NotifyOfPropertyChanged("Ingredients");
            //NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Gets the description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Tells if there is a special request for the order
        /// </summary>
        /*public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (
                return special.ToArray();
            }
        }*/
    }
}
