using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<double>(.99, t.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<uint>(8, t.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.True(t.Ice);
        }

        [Fact]

        public void ShouldHaveDefaultSize()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, t.Size);
        }

        [Fact]

        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.lemon);
        }

        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Sweet);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            Assert.Equal<double>(.99, t.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            Assert.Equal<uint>(8, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<double>(1.49, t.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<double>(1.99, t.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
        }
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.False(t.Ice);
        }
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.True(t.lemon);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmallAndSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddSweet();
            t.Size = Size.Medium;
            t.Size = Size.Small;
            Assert.Equal<uint>(16, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMediumAndSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddSweet();
            t.Size = Size.Medium;
            Assert.Equal<uint>(32, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLargeAndSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddSweet();
            t.Size = Size.Large;
            Assert.Equal<uint>(64, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmallAndNotSweet()
        {
            Tyrannotea t = new Tyrannotea();
            
            t.Size = Size.Medium;
            t.Size = Size.Small;
            
            Assert.Equal<uint>(8, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMediumAndNotSweet()
        {
            Tyrannotea t = new Tyrannotea();
            
            t.Size = Size.Medium;
            
            Assert.Equal<uint>(16, t.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLargeAndNotSweet()
        {
            Tyrannotea t = new Tyrannotea();
            
            t.Size = Size.Large;
            
            Assert.Equal<uint>(32, t.Calories);
        }


        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Small;
            Assert.Equal("Small Tyrannotea", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal("Medium Tyrannotea", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal("Large Tyrannotea", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmallAndSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Small;
            t.Sweet = true;
            Assert.Equal("Small Sweet Tyrannotea", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMediumAndSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Sweet = true;
            Assert.Equal("Medium Sweet Tyrannotea", t.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLargeAndSweet()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.Sweet = true;
            Assert.Equal("Large Sweet Tyrannotea", t.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Description", () =>
            {
                t.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Description", () =>
            {
                t.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Description", () =>
            {
                t.Size = Size.Large;
            });
        }

        [Fact]
        public void AddSweetShouldNotifySpecialChange()
        {
            Tyrannotea t = new Tyrannotea();
            
            Assert.PropertyChanged(t, "Description", () =>
            {
                t.AddSweet();
            });
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldIce();
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.AddLemon();
            });
        }
    }
}