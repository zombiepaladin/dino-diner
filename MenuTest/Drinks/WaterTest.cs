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
            Water tea = new Water();
            Assert.Equal<double>(.10, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water tea = new Water();
            Assert.Equal<double>(0, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.True(tea.Ice);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water tea = new Water();
            Assert.False(tea.Lemon);

        }






        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water tea = new Water();
            tea.Size = Size.Small;
            Assert.Equal<double>(.10, tea.Price);


        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water tea = new Water();
            tea.Size = Size.Medium;
            Assert.Equal<double>(.10, tea.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water tea = new Water();
            tea.Size = Size.Large;
            Assert.Equal<double>(.10, tea.Price);

        }



        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water tea = new Water();
            tea.Size = Size.Small;
            Assert.Equal<uint>(0, tea.Calories);


        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water tea = new Water();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(0, tea.Calories);

        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water tea = new Water();
            tea.Size = Size.Large;
            Assert.Equal<uint>(0, tea.Calories);

        }

        [Fact]
        public void ShouldHoldIce()
        {
            Water tea = new Water();
            tea.HoldIce();
            Assert.False(tea.Ice);

        }

        //That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water ch = new Water();
            Assert.Contains<string>("Water", ch.Ingredients);



            Assert.Single(ch.Ingredients);

        }
    }
}
