using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {

           //The ability to set each possible flavor
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
        public void ShouldBeAbleToSetFlavorToVanila()
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




        // The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }







        //The correct price and calories after changing to small, medium, and large sizes.
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
        //That invoking HoldIce() results in the Ice property being false.
         
          [Fact]
          public void ShouldHaveDefaultPrice()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.True(soda.Ice);

        }



    }
}
