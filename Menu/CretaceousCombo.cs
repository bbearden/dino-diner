/* CretaceourCombo.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Combo class
    /// </summary>
    public class CretaceousCombo 
    {
        /// <summary>
        /// The entree of the combo
        /// </summary>
        public Entree Entree { get; set; }

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
        private Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value; // = value or size
                Side.Size = value; // = value or size
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
    }
}
