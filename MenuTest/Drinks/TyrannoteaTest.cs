using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;
using System.Collections.Generic;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        // The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.Equal<double>(0.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.Equal<double>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.False(tea.Ice);

        }






        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);


        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);

        }



        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);


        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);

        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);

        }
        [Fact]
        public void ShouldHaveHeldIce()
        {
            TyrannoTea ch = new TyrannoTea();
            ch.HoldIce();
            Assert.False(ch.Ice);
        }


        
       

        //That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            TyrannoTea ch = new TyrannoTea();
            Assert.Contains<string>("Water", ch.Ingredients);
            Assert.Contains<string>("Tea", ch.Ingredients);
            
            Assert.True(ch.Ice);
            
            Assert.Contains<string>("Cane Sugar", ch.Ingredients);
            Assert.Equal<int>(3, ch.Ingredients.Count);

        }


    }
}

