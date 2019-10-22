using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;

namespace MenuTest.Sides
{
    public class TriceritotsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Triceritots t = new Triceritots();
            Assert.Equal(0.99, t.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Triceritots t = new Triceritots();
            Assert.Equal<uint>(352, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Triceritots t = new Triceritots();
            Assert.Contains<string>("Potato", t.Ingredients);
            Assert.Contains<string>("Salt", t.Ingredients);
            Assert.Contains<string>("Vegetable Oil", t.Ingredients);
            Assert.Equal<int>(3, t.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Triceritots t = new Triceritots();
            Assert.Equal<Size>(Size.Small, t.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Medium;
            Assert.Equal(1.45, t.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Medium;
            Assert.Equal<uint>(410, t.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, t.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Large;
            Assert.Equal(1.95, t.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Large;
            Assert.Equal<uint>(590, t.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, t.Size);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Small;
            Assert.Equal("Small Triceritots", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Medium;
            Assert.Equal("Medium Triceritots", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            Triceritots t = new Triceritots();
            t.Size = Size.Large;
            Assert.Equal("Large Triceritots", t.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            Triceritots t = new Triceritots(); ;
            Assert.Empty(t.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Description", () =>
            {
                t.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Description", () =>
            {
                t.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            Triceritots t = new Triceritots();
            Assert.PropertyChanged(t, "Description", () =>
            {
                t.Size = Size.Large;
            });
        }
    }
}