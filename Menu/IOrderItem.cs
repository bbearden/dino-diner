﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// declaration of Price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the description of the order item 
        /// </summary>
        string Description { get; }

        /// <summary>
        /// tells if there is any special request on the order
        /// </summary>
        string[] Special { get; }
    }
}
