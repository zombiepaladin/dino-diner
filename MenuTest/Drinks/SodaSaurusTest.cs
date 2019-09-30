using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using Xunit;
using System.Collections.Generic;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {

        //The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);



        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);



        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanila()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);



        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToChoclate()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);



        }




        // The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TyrannoTea soda = new TyrannoTea();
            Assert.Equal<double>(1.50, soda.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TyrannoTea soda = new TyrannoTea();
            Assert.Equal<double>(112, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            TyrannoTea soda = new TyrannoTea();
            Assert.True(soda.Ice);

        }






        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);


        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);

        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);

        }



        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);


        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);

        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            TyrannoTea soda = new TyrannoTea();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);

        }


        //That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            TyrannoTea ch = new TyrannoTea();
            Assert.Contains<string>("Water", ch.Ingredients);
            Assert.Contains<string>("Natural Flavors", ch.Ingredients);
            Assert.Contains<string>("Cane Sugar", ch.Ingredients);
            Assert.Equal<int>(3, ch.Ingredients.Count);
            

        }


    }
}
