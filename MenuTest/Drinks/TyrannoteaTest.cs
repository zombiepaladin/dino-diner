using DinoDiner.Menu;

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
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.ice);

        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(Size.Small, tea.Size);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.lemon);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.sweet);

        }
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.ice);


        }

        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.lemon);
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);


        }

        [Fact]
        public void ShouldAddSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            Assert.True(tea.sweet);
            Assert.Equal<double>(8 * 2, tea.Calories);
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);

        }
        [Fact]
        public void ShouldRemoveSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.RemoveSweet();
            Assert.False(tea.sweet);
            Assert.Equal<double>(8 , tea.Calories);



        }





        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);


        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);

        }



        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);


        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);

        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);

        }
       

        
       

        //That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea ch = new Tyrannotea();
            Assert.Contains<string>("Water", ch.Ingredients);
            Assert.Contains<string>("Tea", ch.Ingredients);
            Assert.Equal<int>(2, ch.Ingredients.Count);
            Assert.True(ch.ice);

        }


    }
}

