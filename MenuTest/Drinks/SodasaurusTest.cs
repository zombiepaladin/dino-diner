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
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, s.Flavor);

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

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<double>(1.50, s.Price);
        }


        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Small;
            Assert.Equal<double>(1.50, s.Price);

        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            Assert.Equal<double>(2.00, s.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal<double>(2.50, s.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Small;
            Assert.Equal<double>(112, s.Calories);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            Assert.Equal<double>(156, s.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal<double>(208, s.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.True(s.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Sodasaurus s = new Sodasaurus();

            Assert.True(s.Calories == 112);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Sodasaurus s = new Sodasaurus();

            Assert.True(s.Size == Size.Small);
        }

        [Fact]
        public void ShouldHaveHoldIce()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.False(s.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Contains("Water", s.Ingredients);
            Assert.Contains("Natural Flavors", s.Ingredients);
            Assert.Contains("Cane Sugar", s.Ingredients);
            
        }
    }
}
