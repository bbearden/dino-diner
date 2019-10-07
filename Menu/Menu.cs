/* Menu.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Complete Menu for DinoDiner
    /// </summary>
    public class Menu 
    {
        /// <summary>
        /// All available DinoDiner menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> availableMenuItems = new List<IMenuItem>();

                //add available entrees
                Brontowurst bw = new Brontowurst();
                availableMenuItems.Add(bw);
                DinoNuggets dn = new DinoNuggets();
                availableMenuItems.Add(dn);
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                availableMenuItems.Add(pbj);
                PterodactylWings pw = new PterodactylWings();
                availableMenuItems.Add(pw);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                availableMenuItems.Add(sb);
                TRexKingBurger trex = new TRexKingBurger();
                availableMenuItems.Add(trex);
                VelociWrap vw = new VelociWrap();
                availableMenuItems.Add(vw);

                //adds available sides
                Fryceritops fry = new Fryceritops();
                availableMenuItems.Add(fry);
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                availableMenuItems.Add(mac);
                MezzorellaSticks ms = new MezzorellaSticks();
                availableMenuItems.Add(ms);
                Triceritots tots = new Triceritots();
                availableMenuItems.Add(tots);

                //adds available drinks
                JurassicJava jj = new JurassicJava();
                availableMenuItems.Add(jj);
                Sodasaurus soda = new Sodasaurus();
                availableMenuItems.Add(soda);
                Tyrannotea tt = new Tyrannotea();
                availableMenuItems.Add(tt);
                Water w = new Water();
                availableMenuItems.Add(w);

                return availableMenuItems;
            }
        }

        /// <summary>
        /// All available DinoDiner Entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> availableEntrees = new List<Entree>();
                foreach (IMenuItem menuItem in AvailableMenuItems)
                {
                    if (menuItem is Entree)
                    {
                        availableEntrees.Add((Entree)menuItem);
                    }
                }
                return availableEntrees;
            }
        }

        /// <summary>
        /// All available DinoDiner Sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> availableSides = new List<Side>();
                foreach (IMenuItem menuItem in AvailableMenuItems)
                {
                    if (menuItem is Side)
                    {
                        availableSides.Add((Side)menuItem);
                    }
                }
                return availableSides;
            }
        }

        /// <summary>
        /// All available DinoDiner Drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> availableDrinks = new List<Drink>();
                foreach (IMenuItem menuItem in AvailableMenuItems)
                {
                    if (menuItem is Drink)
                    {
                        availableDrinks.Add((Drink)menuItem);
                    }
                }
                return availableDrinks;
            }
        }

        /// <summary>
        /// All available DinoDiner Combos
        /// </summary>
        public List<CretaceousCombo> availableCombos
        {
            get
            {
                List<CretaceousCombo> availableCombos = new List<CretaceousCombo>();
                foreach(IMenuItem menuItem in AvailableMenuItems)
                {
                    if(menuItem is Entree)
                    {
                        availableCombos.Add((CretaceousCombo)menuItem);
                    }
                }
                return availableCombos;
            }
        }

        /// <summary>
        /// Displays the full menu contents
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string menu = "";
            foreach(IMenuItem menuItem in AvailableMenuItems)
            {
                menu += menuItem.ToString() + "\n";
            }
            return menu;
        }
    }
}
