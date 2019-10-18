/* VelociWrap.cs
 * Author: Branden Bearden
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{   
    /// <summary>
    /// Menu order for VelociWrap 
    /// </summary>
    public class VelociWrap : Entree, INotifyPropertyChanged
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
        /// Indicates if lettuce is on the wrap 
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// Indicates if dressing is on the wrap
        /// </summary>
        private bool Dressing = true;
        /// <summary>
        /// Indicates if cheese is on the wrap
        /// </summary>
        private bool Cheese = true;

        /// <summary>
        /// Constructor setting initial price, calories, and List of ingredients from Entree base class
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            
        }

        /// <summary>
        /// Overrides Ingredients List from Entree base c
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if(Lettuce) ingredients.Add("Romaine Lettuce");
                if(Dressing) ingredients.Add("Ceasar Dressing");
                if(Cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
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
        /// Holds dressing if requested
        /// </summary>
        public void HoldDressing()
        {
            this.Dressing = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the cheese if requested
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The name of the order
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
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
                if (!Lettuce) special.Add("Hold Romaine Lettuce");
                if (!Dressing) special.Add("Hold Ceasar Dressing");
                if (!Cheese) special.Add("Hold Parmesan Cheese");
                return special.ToArray();
            }
        }
    }
}
