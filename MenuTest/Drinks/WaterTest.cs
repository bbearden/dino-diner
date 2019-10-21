/* WaterTest.cs
 * Author: Branden Bearden
 */ 
using System;
using System.Collections.Generic;
using System.Text;
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

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeCorrectForEachSize(Size size)
        {
            Water w = new Water();
            w.Size = size;
            Assert.Equal($"{size} Water", w.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Water w = new Water();
            Assert.Empty(w.Special);
        }

        [Fact]
        public void HoldIceShouldAddtoSpecial()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void AddLemonShouldAddtoSpecial()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void HoldAllShouldAddtoSpecial()
        {
            Water w = new Water();
            w.AddLemon();
            w.HoldIce();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldDescriptionChange(Size size)
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Description", () =>
            {
                w.Size = size;
            });
        }

        [Fact]
        public void AddLemonShouldSpecialChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special", () =>
            {
                w.AddLemon();
            });
        }

        [Fact]
        public void HoldIceShouldSpecialChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special", () =>
            {
                w.HoldIce();
            });
        }
    }
}
