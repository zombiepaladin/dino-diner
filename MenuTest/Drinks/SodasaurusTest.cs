using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        ///The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new DinoDiner.Menu.Drinks.Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);

        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, s.Flavor);

        }
        
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, s.Flavor);

        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, s.Flavor);

        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, s.Flavor);

        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, s.Flavor);

        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, s.Flavor);

        }

        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }


        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);

        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(112, soda.Calories);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(208, soda.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();

            Assert.True(soda.Calories == 112);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();

            Assert.True(soda.Size == Size.Small);
        }

        [Fact]
        public void ShouldHaveHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains("Water", soda.Ingredients);
            Assert.Contains("Natural Flavors", soda.Ingredients);
            Assert.Contains("Cane Sugar", soda.Ingredients);
            
        }
    }
}
