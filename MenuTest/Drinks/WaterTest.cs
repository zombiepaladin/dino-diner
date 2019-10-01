using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
namespace Menu.Drinks
{
    public class WaterTest
    {
        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water(); 
            Assert.Equal<double>(.10, w.Price);
        }


        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<double>(.10, w.Price);

        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(.10, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(.10, w.Price);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<double>(0, w.Calories);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Water w = new Water();
            
            Assert.Equal<double>(.10, w.Price);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water w = new Water();

            Assert.True(w.Size == Size.Small);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Water w = new Water();

            Assert.True(w.Calories == 0);
        }

        [Fact]
        public void ShouldHaveHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        [Fact]
        public void ShouldHaveLemon()
        {
            Water w = new Water();

            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        [Fact]
        public void ShouldDefaultLemon()
        {
            Water w = new Water();
            
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water w = new Water();
            Assert.Contains("Water", w.Ingredients);
            if (w.Lemon) Assert.Contains("Lemon", w.Ingredients);
        }

    }
}
