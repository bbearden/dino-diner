/* MockDrink.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MockDrink : Drink
    {
        /// <summary>
        /// Declaration of Inherited method
        /// </summary>
        public override string Description => throw new NotImplementedException();

        /// <summary>
        /// Declaration of inherited method
        /// </summary>
        public override string[] Special => throw new NotImplementedException();

        /// <summary>
        /// Mock Drink constructor setting price
        /// </summary>
        /// <param name="price"></param>
        public MockDrink(double price)
        {
            Price = price;
        }
    }
}
