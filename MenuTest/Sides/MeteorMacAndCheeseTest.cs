using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;

namespace MenuTest.Sides
{
    public class MeteorMacAndCheeseTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.Equal(0.99, m.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.Equal<uint>(420, m.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.Contains<string>("Macaroni Noodles", m.Ingredients);
            Assert.Contains<string>("Cheese Product", m.Ingredients);
            Assert.Contains<string>("Pork Sausage", m.Ingredients);
            Assert.Equal<int>(3, m.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.Equal<Size>(Size.Small, m.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Medium;
            Assert.Equal(1.45, m.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Medium;
            Assert.Equal<uint>(490, m.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, m.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Large;
            Assert.Equal(1.95, m.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Large;
            Assert.Equal<uint>(520, m.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, m.Size);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Small;
            Assert.Equal("Small Meteor Mac and Cheese", m.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Medium;
            Assert.Equal("Medium Meteor Mac and Cheese", m.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            m.Size = Size.Large;
            Assert.Equal("Large Meteor Mac and Cheese", m.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.Empty(m.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Description", () =>
            {
                m.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Description", () =>
            {
                m.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            Assert.PropertyChanged(m, "Description", () =>
            {
                m.Size = Size.Large;
            });
        }
    }
}