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
            Sodasaurus tea = new Sodasaurus();
            Assert.Equal<double>(1.50, tea.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus tea = new Sodasaurus();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Sodasaurus tea = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }
        
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus tea = new Sodasaurus();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(1.50, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {

            Sodasaurus tea = new Sodasaurus();
            tea.Size = Size.Medium;
            Assert.Equal<double>(2.00, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus tea = new Sodasaurus();
            tea.Size = Size.Large;
            Assert.Equal<double>(2.50, tea.Price);
        }
        
        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void HoldIceShouldemoveIce()
        {
            Sodasaurus tea = new Sodasaurus();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        
        //That invoking AddLemon() sets results in the Lemon property being true.
        
        //That setting the sweet property to true results in the right calories for each size
        //That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
    }
}
