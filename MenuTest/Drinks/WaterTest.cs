using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
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
        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.lemon);
        }

        
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<double>(.10, w.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
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
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
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
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }

        
        [Fact]
        public void ShouldHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }
        
        [Fact]
        public void ShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.lemon);
        }

   

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal("Small Water", w.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal("Medium Water", w.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal("Large Water", w.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            Water w = new Water();
            Assert.Empty(w.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Description", () =>
            {
                w.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Description", () =>
            {
                w.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Description", () =>
            {
                w.Size = Size.Large;
            });
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Collection<string>(w.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special", () =>
            {
                w.HoldIce();
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special", () =>
            {
                w.AddLemon();
            });
        }
    }
}