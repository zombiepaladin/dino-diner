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
            JurassicJava j = new JurassicJava();
            Assert.Equal<double>(.59, j.Price);
        }


        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);

        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(.99, j.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(1.49, j.Price);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Small;
            Assert.Equal<double>(2, j.Calories);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(4, j.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(8, j.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava j = new JurassicJava();
            Assert.False(j.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurassicJava j = new JurassicJava();

            Assert.True(j.Calories == 2);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava j = new JurassicJava();

            Assert.True(j.Size == Size.Small);
        }

        [Fact]
        public void ShouldHaveAddIce()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava j = new JurassicJava();
            Assert.Contains("Water", j.Ingredients);
            Assert.Contains("Coffee", j.Ingredients);

            


        }

        [Fact]
        public void ShouldHaveLeaveRoomForCream()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);

        }

        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurassicJava j = new JurassicJava();
            
            Assert.False(j.RoomForCream);

        }

       

    }
}
