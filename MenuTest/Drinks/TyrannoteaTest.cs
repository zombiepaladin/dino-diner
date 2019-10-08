using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>( .99,tea.Price);
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
        
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(8, tea.Calories);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
            Assert.Equal<double>(.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            
            Assert.True(tea.Size == Size.Small);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();

            Assert.True(tea.Calories == 8);
        }

        [Fact]
        public void ShouldHaveHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        [Fact]
        public void ShouldHaveLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void ShouldHaveSweet()
        {
            Tyrannotea tea = new Tyrannotea();

            Assert.False(tea.Sweet);
        }

        [Fact]
        public void ShouldHaveSweetSetTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            
            Assert.Equal<double>(16, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<double>(32, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<double>(64, tea.Calories);



        }

        [Fact]
        public void ShouldHaveSweetSetFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;

            tea.Size = Size.Small;
            Assert.Equal<double>(8, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<double>(16, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<double>(32, tea.Calories);


        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains("Water", tea.Ingredients);
            Assert.Contains("Tea", tea.Ingredients);
            if(tea.Sweet) Assert.Contains("Cane Sugar", tea.Ingredients);
            if(tea.Lemon) Assert.Contains("Lemon", tea.Ingredients);
        }
    }
}
