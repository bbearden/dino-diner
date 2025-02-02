﻿/* Drink.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    

    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
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

        protected List<string> ingredients = new List<string>(); //MAYBE

        /// <summary>
        /// Declares Size enum from Size.cs
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the ingredient list
        /// </summary>
        public virtual List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// tells if there is ice in the drink
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the description of the order
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Tells if there is a special request for the order
        /// </summary>
        public abstract string[] Special { get; }

    }
}
