/* MockSide.cs
 * Author: Branden Bearden
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MockSide : Side
    {
        /// <summary>
        /// Declaration of inherited method
        /// </summary>
        public override string Description => throw new NotImplementedException();

        /// <summary>
        /// Declaration of inherited class
        /// </summary>
        public override string[] Special => throw new NotImplementedException();

        /// <summary>
        /// Mock side consructor setting price
        /// </summary>
        /// <param name="price"></param>
        public MockSide(double price)
        {
            Price = price;
        }
    }
}
