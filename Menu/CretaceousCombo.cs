/* CretaceourCombo.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;


namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {

        public Entree Entree { get; set; }


        private Side side;

        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }


        private Drink drink;

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


        private Size size = Size.Small;

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


        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();

        }
    }
}
