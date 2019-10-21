using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MeteorMacAndCheeseTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.Equal(0.99, mac.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.Equal<uint>(420, mac.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.Contains<string>("Macaroni Noodles", mac.Ingredients);
            Assert.Contains<string>("Cheese Product", mac.Ingredients);
            Assert.Contains<string>("Pork Sausage", mac.Ingredients);
            Assert.Equal<int>(3, mac.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.Equal<Size>(Size.Small, mac.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = Size.Medium;
            Assert.Equal(1.45, mac.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = Size.Medium;
            Assert.Equal<uint>(490, mac.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, mac.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = Size.Large;
            Assert.Equal(1.95, mac.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = Size.Large;
            Assert.Equal<uint>(520, mac.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, mac.Size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeCorrectForEachSize(Size size)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mac.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.Empty(mac.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldPriceChange(Size size)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.PropertyChanged(mac, "Price", () =>
            {
                mac.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldCalorieChange(Size size)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.PropertyChanged(mac, "Calories", () =>
            {
                mac.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldDescriptionChange(Size size)
        {
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            Assert.PropertyChanged(mac, "Description", () =>
            {
                mac.Size = size;
            });
        }
    }
}
