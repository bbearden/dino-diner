/* MockEntree.cs
 * Author: Branden Bearden
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuTest
{
    public class MockEntree : Entree
    {
        /// <summary>
        /// Declaration of Inherited Method
        /// </summary>
        public override string Description => throw new NotImplementedException();

        /// <summary>
        /// Declaration of inherited Method
        /// </summary>
        public override string[] Special => throw new NotImplementedException();

        /// <summary>
        /// Mock Entree constructor setting price
        /// </summary>
        /// <param name="price"></param>
        public MockEntree(double price)
        {
            Price = price;
        }
    }
}
