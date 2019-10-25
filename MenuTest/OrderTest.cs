/* MockTest.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalCostTest()
        {
            MockEntree me = new MockEntree(5.50);
            MockSide ms = new MockSide(3.00);
            MockDrink md = new MockDrink(2.50);
            Order o = new Order();

            o.Add(me);
            o.Add(ms);
            o.Add(md);

            Assert.Equal<double>(11.00, o.SubtotalCost);
        }

        [Fact]
        public void SalesTaxTest()
        {
            MockEntree me = new MockEntree(5.50);
            MockSide ms = new MockSide(3.00);
            MockDrink md = new MockDrink(2.50);
            Order o = new Order();

            o.Add(me);
            o.Add(ms);
            o.Add(md);

            Assert.Equal<double>(.60, o.SalesTaxCost);
        }

        [Fact]
        public void TotalCostTest()
        {
            MockEntree me = new MockEntree(5.50);
            MockSide ms = new MockSide(3.00);
            MockDrink md = new MockDrink(2.50);
            Order o = new Order();

            o.Add(me);
            o.Add(ms);
            o.Add(md);

            Assert.Equal<double>(11.60, o.TotalCost);
        }

        [Fact]
        public void NegativeTotalCostShouldBeZero()
        {
            MockEntree me = new MockEntree(5.50);
            MockSide ms = new MockSide(-3.00);
            MockDrink md = new MockDrink(-2.50);
            Order o = new Order();

            o.Add(me);
            o.Add(ms);
            o.Add(md);

            Assert.Equal<double>(0, o.SubtotalCost);
        }
    }
}
