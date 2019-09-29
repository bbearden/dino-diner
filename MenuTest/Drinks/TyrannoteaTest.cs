using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default price, calories, ice, size, lemon, and sweet properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(1.50, tea.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingMedium()
        {

            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
            Assert.Equal<uint>(32, tea.Calories);

        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void HoldIceShouldemoveIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        
        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains<string>("Lemon", tea.Ingredients);
        }

        //That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmallWithSweetener()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }


        [Fact]
        public void ShouldHaveCorrectCaloriesForMediumWithSweetener()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }


        [Fact]
        public void ShouldHaveCorrectCaloriesForLargeWithSweetener()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }

        //That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            tea.Sweetener = false;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }


        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            tea.Sweetener = false;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }


        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            tea.Sweetener = false;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //The correct ingredients are given
        [Fact]
        public void ShouldContainAllIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Natural Flavors", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
        }
    }
}
