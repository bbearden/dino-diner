/* WaterTest.cs
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
    public class WaterTest
    {
        //The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(.10, w.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<double>(.10, w.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {

            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(.10, w.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesAfterSettingMedium()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(.10, w.Price);

        }

        [Fact]
        public void ShouldUseCorrectCaloriesAfterSettingLarge()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldContainAllIngredients()
        {
            Water w = new Water();
            List<string> ingredients = w.Ingredients;
            Assert.Contains<string>("Water", w.Ingredients);
        }

        [Fact]
        public void ShouldContainAllIngredientsSpecified()
        {
            Water w = new Water();
            List<string> ingredients = w.Ingredients;
            w.AddLemon();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Contains<string>("Lemon", w.Ingredients);
        }
    }
}
