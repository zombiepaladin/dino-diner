using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
       

        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Equal<double>(.59, j.Price);
        }


        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);

        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(.99, j.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(1.49, j.Price);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Small;
            Assert.Equal<double>(2, j.Calories);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(4, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(8, j.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.False(j.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurrasicJava j = new JurrasicJava();

            Assert.True(j.Calories == 2);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurrasicJava j = new JurrasicJava();

            Assert.True(j.Size == Size.Small);
        }

        [Fact]
        public void ShouldHaveAddIce()
        {
            JurrasicJava j = new JurrasicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Contains("Water", j.Ingredients);
            Assert.Contains("Coffee", j.Ingredients);

            


        }

        [Fact]
        public void ShouldHaveLeaveRoomForCream()
        {
            JurrasicJava j = new JurrasicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);

        }

        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurrasicJava j = new JurrasicJava();
            
            Assert.False(j.RoomForCream);

        }

       

    }
}
