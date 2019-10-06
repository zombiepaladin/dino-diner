using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;
using System.Collections.Generic;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        // The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water wat = new Water();
            Assert.Equal<double>(.10, wat.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water wat = new Water();
            Assert.Equal<double>(0, wat.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water wat = new Water();
            Assert.True(wat.Ice);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water wat = new Water();
            Assert.False(wat.Lemon);

        }






        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Small;
            Assert.Equal<double>(.10, wat.Price);


        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<double>(.10, wat.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<double>(.10, wat.Price);

        }



        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Small;
            Assert.Equal<uint>(0, wat.Calories);


        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<uint>(0, wat.Calories);

        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<uint>(0, wat.Calories);

        }

        [Fact]
        public void ShouldHoldIce()
        {
            Water wat = new Water();
            wat.HoldIce();
            Assert.False(wat.Ice);

        }
        [Fact]
        public void ShouldAddLemon()
        {
            Water wat = new Water();
            wat.AddLemon();
            Assert.True(wat.Lemon);
            Assert.Contains<string>("Water", wat.Ingredients);
            Assert.Contains<string>("Lemon", wat.Ingredients);
            Assert.Equal<int>(2, wat.Ingredients.Count);

        }

        //That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water wat = new Water();
            Assert.Contains<string>("Water", wat.Ingredients);
            Assert.Single(wat.Ingredients);

        }
    }
}
