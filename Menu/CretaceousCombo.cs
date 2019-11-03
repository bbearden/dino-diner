/* CretaceourCombo.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Combo class
    /// </summary>
    public class CretaceousCombo : INotifyPropertyChanged
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


        private Entree entree;

        /// <summary>
        /// The entree of the combo
        /// </summary>
        public Entree Entree {
            get { return entree; }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
                
            }

        }

        /// <summary>
        /// the side of the combo
        /// </summary>
        private Side side;

        /// <summary>
        /// the side and its size for the combo
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }

        /// <summary>
        /// The drink of the combo
        /// </summary>
        private Drink drink;

        /// <summary>
        /// The drink and its size for the combo
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                drink.Size = size;
               //NotifyOfPropertyChanged("Ingredients");
                //NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                //NotifyOfPropertyChanged("Calories");
                //NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// total price of the combo with a 25 cent discount
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - .25;
            }
        }

        /// <summary>
        /// total calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// defualt size
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// The size of the drink and side
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value; // = value or size
                Side.Size = value; // = value or size

                //NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                //NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// the ingredients of the entree, side, and drink making up the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                Ingredients.AddRange(Entree.Ingredients);
                Ingredients.AddRange(Side.Ingredients);
                Ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// The combo put together
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Tyrannotea();

        }

        /// <summary>
        /// The name of the combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Entree + " Combo";
        }

        /// <summary>
        /// gives the description of the order
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// tells if there is a special request for the order
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }
    }
}
