using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;
using System.Collections.Generic;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {

        
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);



        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToChoclate()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }



        
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
             SodaSaurus soda= new SodaSaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Equal<double>(112, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.True(soda.Ice);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Equal(Size.Small, soda.Size);

        }





        
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);


        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);

        }



        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);


        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);

        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);

        }


        [Fact]
        public void ShouldHoldIce()
        {
            SodaSaurus ch = new SodaSaurus();
            ch.HoldIce();
            Assert.False(ch.Ice);


        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            SodaSaurus ch = new SodaSaurus();
            Assert.Contains<string>("Water", ch.Ingredients);
            Assert.Contains<string>("Natural Flavors", ch.Ingredients);
            Assert.Contains<string>("Cane Sugar", ch.Ingredients);
            Assert.Equal<int>(3, ch.Ingredients.Count);
            

        }


    }
}
