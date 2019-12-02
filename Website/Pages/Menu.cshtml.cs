using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// the search filter input
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// list of strings based on the item category (Combo, Entree, Side, or Drink)
        /// </summary>
        [BindProperty]
        public List<string> Category { get; set; } = new List<string>();

        /// <summary>
        /// the minimum price inputed
        /// </summary>
        [BindProperty]
        public float? minimumPrice { get; set; }

        /// <summary>
        /// the maximum price inputed
        /// </summary>
        [BindProperty]
        public float? maximumPrice { get; set; }

        /// <summary>
        /// incredients excluded
        /// </summary>
        [BindProperty]
        public List<string> ingredient { get; set; } = new List<string>();

        // List of all combos, entrees, drinks, and sides
        public List<IMenuItem> Combos;
        public List<IMenuItem> Entrees;
        public List<IMenuItem> Sides;
        public List<IMenuItem> Drinks;

        public Menu Menu { get { return new Menu(); } }

        /// <summary>
        /// method for get form
        /// </summary>
        public void OnGet()
        {
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
        }

        public void OnPost()
        {
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;

            if(search != null)
            {
                Combos = Search(Combos, search);
                Entrees = Search(Entrees, search);
                Sides = Search(Sides, search);
                Drinks = Search(Drinks, search);
            }

            if(Category.Count != 0)
            {
                FilterByCategory(Category);
            }

            if(minimumPrice != null)
            {
                Combos = FilterByMinPrice(Combos, (float)minimumPrice);
                Entrees = FilterByMinPrice(Entrees, (float)minimumPrice);
                Sides = FilterByMinPrice(Sides, (float)minimumPrice);
                Drinks = FilterByMinPrice(Drinks, (float)minimumPrice);
            }

            if(maximumPrice != null)
            {
                Combos = FilterByMaxPrice(Combos, (float)maximumPrice);
                Entrees = FilterByMaxPrice(Entrees, (float)maximumPrice);
                Sides = FilterByMaxPrice(Sides, (float)maximumPrice);
                Drinks = FilterByMaxPrice(Drinks, (float)maximumPrice);
            }

            if(ingredient.Count != 0)
            {
                Combos = FilterByExcludedIngredients(Combos, ingredient);
                Entrees = FilterByExcludedIngredients(Entrees, ingredient);
                Sides = FilterByExcludedIngredients(Sides, ingredient);
                Drinks = FilterByExcludedIngredients(Drinks, ingredient);
            }
        }

        /// <summary>
        /// Searches for an item in the menu based on the search bar
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static List<IMenuItem> Search(List<IMenuItem> menu, string searchString)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach(IMenuItem item in menu)
            {
                if(item.ToString() != null && item.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// filters based on the item type (Combo, Entree, Side, Drink)
        /// </summary>
        /// <param name="category"></param>
        public void FilterByCategory(List<string> category)
        {
            if (!category.Contains("Combo"))
            {
                Combos = new List<IMenuItem>();
            }

            if (!category.Contains("Entree"))
            {
                Entrees = new List<IMenuItem>();
            }

            if (!category.Contains("Side"))
            {
                Sides = new List<IMenuItem>();
            }

            if (!category.Contains("Drink"))
            {
                Drinks = new List<IMenuItem>();
            }
        }

        /// <summary>
        /// filters by the minimum price
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="price">the filter price</param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> category, float price)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach(IMenuItem item in category)
            {
                if(price <= item.Price)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// filters by the maximum price
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> category, float price)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in category)
            {
                if (price >= item.Price)
                {
                    result.Add(item);
                }
            }
            return result;
        }


        public static List<IMenuItem> FilterByExcludedIngredients(List<IMenuItem> category, List<string> excluded)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach(IMenuItem item in category)
            {
                if (!excluded.Contains(item.Ingredients.ToString()))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}