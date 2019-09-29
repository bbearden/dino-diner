/* JurrasicJavaTest.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<double>(.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.RoomForCream);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<double>(.59, jj.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSmall()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {

            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(.99, jj.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void AddIceShouldAddIce()
        {
            JurrasicJava jj= new JurrasicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldLeaveRoomForCreamAfterLeaveRoomForCream()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurrasicJava jj = new JurrasicJava();
            List<string> ingredients = jj.Ingredients;
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
        }
    }
}
