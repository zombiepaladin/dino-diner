using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<double>(.59, j.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<uint>(2, j.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava j = new JurassicJava();
            Assert.False(j.Ice);
        }

        [Fact]

        public void ShouldHaveDefaultSize()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<Size>(Size.Small, j.Size);
        }

        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurassicJava j = new JurassicJava();
            Assert.False(j.RoomForCream);
        }


        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            j.Size = Size.Small;
            Assert.Equal<uint>(2, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(.99, j.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<uint>(4, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(1.49, j.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<uint>(8, j.Calories);
        }
        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }
        [Fact]
        public void LeaveSpaceForCream()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }


        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Small;
            Assert.Equal("Small Jurassic Java", j.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal("Medium Jurassic Java", j.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal("Large Jurassic Java", j.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmallAndDecaf()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Small;
            j.decaf = true;
            Assert.Equal("Small Decaf Jurassic Java", j.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMediumAndDecaf()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            j.decaf = true;
            Assert.Equal("Medium Decaf Jurassic Java", j.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLargeAndDecaf()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            j.decaf = true;
            Assert.Equal("Large Decaf Jurassic Java", j.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            JurassicJava j = new JurassicJava();
            Assert.Empty(j.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Size = Size.Large;
            });
        }

        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldAddToSpecial()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.Collection<string>(j.Special, item =>
            {
                Assert.Equal("Room For Cream", item);
            });
        }

        [Fact]
        public void AddIceShouldNotifySpecialChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.AddIce();
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifySpecialChange()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.LeaveRoomForCream();
            });
        }
    }
}