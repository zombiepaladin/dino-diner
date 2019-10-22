using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;

namespace MenuTest.Sides
{
    public class MezzorellaSticksTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.Equal(0.99, m.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.Equal<uint>(540, m.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.Contains<string>("Breading", m.Ingredients);
            Assert.Contains<string>("Cheese Product", m.Ingredients);
            Assert.Contains<string>("Vegetable Oil", m.Ingredients);
            Assert.Equal<int>(3, m.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.Equal<Size>(Size.Small, m.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Medium;
            Assert.Equal(1.45, m.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Medium;
            Assert.Equal<uint>(610, m.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, m.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Large;
            Assert.Equal(1.95, m.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Large;
            Assert.Equal<uint>(720, m.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, m.Size);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Small;
            Assert.Equal("Small Mezzorella Sticks", m.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Medium;
            Assert.Equal("Medium Mezzorella Sticks", m.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            m.Size = Size.Large;
            Assert.Equal("Large Mezzorella Sticks", m.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.Empty(m.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Description", () =>
            {
                m.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Description", () =>
            {
                m.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            MezzorellaSticks m = new MezzorellaSticks();
            Assert.PropertyChanged(m, "Description", () =>
            {
                m.Size = Size.Large;
            });
        }
    }
}