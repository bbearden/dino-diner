using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        private Size size;
        public override Size Size
        {
            set
            {
                Size = value;
                switch (Size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        public Triceritots()
        {
            Price = 0.98;
            Calories = 352;
            Ingredients.Add("Potato");
            Ingredients.Add("Breading");
            Ingredients.Add("Vegetable Oil");

        }
    }
}
