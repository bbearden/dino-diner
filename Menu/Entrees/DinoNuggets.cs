using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
 
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", };
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
        }

        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.Ingredients.Add("Chicken Nugget");
        }
    }
}
