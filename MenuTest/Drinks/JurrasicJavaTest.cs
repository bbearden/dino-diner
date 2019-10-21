/* JurrasicJavaTest.cs
 * Author: Branden Bearden
 */ 

using System;
using System.Collections.Generic;
using System.Text;
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
            JurassicJava jj = new JurassicJava();
            Assert.Equal<double>(.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.RoomForCream);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<double>(.59, jj.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {

            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(.99, jj.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void AddIceShouldAddIce()
        {
            JurassicJava jj= new JurassicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldLeaveRoomForCreamAfterLeaveRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurassicJava jj = new JurassicJava();
            List<string> ingredients = jj.Ingredients;
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void DescriptionShouldBeCorrectForEachSize(Size size, bool decaf)
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = size;
            if (!decaf)
            {
                Assert.Equal($"{size} Jurassic Java", jj.Description);
            }
            else
            {
                jj.Decafinate();
                Assert.Equal($"{size} Decaf Jurassic Java", jj.Description);
            }
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Empty(jj.Special);
        }

        [Fact]
        public void AddIceShouldAddtoSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldAddtoSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Room for Cream", item);
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldPriceChange(Size size)
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Price", () =>
            {
                jj.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldCalorieChange(Size size)
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Calories", () =>
            {
                jj.Size = size;
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldSpecialChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.LeaveRoomForCream();
            });
        }

        [Fact]
        public void AddIceShouldSpecialChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.AddIce();
            });
        }

        [Fact]
        public void DecafinateShouldDescriptionChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.Decafinate();
            });
        }

        [Fact]
        public void HoldAllShouldAddToSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            },
            item =>
            {
                Assert.Equal("Add Room for Cream", item);
            });
        }
    }
}
