using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;

namespace MenuTest.Sides
{
    public class FryceritopsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Fryceritops f = new Fryceritops();
            Assert.Equal(0.99, f.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Fryceritops f = new Fryceritops();
            Assert.Equal<uint>(222, f.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Fryceritops f = new Fryceritops();
            Assert.Contains<string>("Potato", f.Ingredients);
            Assert.Contains<string>("Salt", f.Ingredients);
            Assert.Contains<string>("Vegetable Oil", f.Ingredients);
            Assert.Equal<int>(3, f.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Fryceritops f = new Fryceritops();
            Assert.Equal<Size>(Size.Small, f.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Medium;
            Assert.Equal(1.45, f.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Medium;
            Assert.Equal<uint>(365, f.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, f.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Large;
            Assert.Equal(1.95, f.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Large;
            Assert.Equal<uint>(480, f.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, f.Size);
        }


        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Small;
            Assert.Equal("Small Fryceritops", f.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Medium;
            Assert.Equal("Medium Fryceritops", f.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            Fryceritops f = new Fryceritops();
            f.Size = Size.Large;
            Assert.Equal("Large Fryceritops", f.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            Fryceritops f = new Fryceritops();
            Assert.Empty(f.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Description", () =>
            {
                f.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Description", () =>
            {
                f.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            Fryceritops f = new Fryceritops();
            Assert.PropertyChanged(f, "Description", () =>
            {
                f.Size = Size.Large;
            });
        }
    }
}