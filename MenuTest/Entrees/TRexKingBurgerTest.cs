using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }


      


        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {

            TRexKingBurger pbj = new TRexKingBurger();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            TRexKingBurger pbj = new TRexKingBurger();
            pbj.HoldOnion();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }



                );
        }



        [Fact]
        public void SpecialShouldHoldPickle()
        {
            TRexKingBurger pbj = new TRexKingBurger();
            pbj.HoldPickle();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Pickles", item);
                }



                );
        }

        [Fact]
        public void SpecialShouldHoldTomato()
        {
            TRexKingBurger pbj = new TRexKingBurger();
            pbj.HoldTomato();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                }



                );
        }

        [Fact]
        public void SpecialShouldHoldMayo()
        {
            TRexKingBurger pbj = new TRexKingBurger();
            pbj.HoldMayo();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }



                );
        }


        [Fact]
        public void SpecialShouldHoldMustard()
        {
            TRexKingBurger pbj = new TRexKingBurger();
            pbj.HoldMustard();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }



                );
        }


        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            TRexKingBurger pbj = new TRexKingBurger();
            pbj.HoldLettuce();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }



                );
        }




        [Fact]
        public void SpecialShouldHoldAll()
        {
            TRexKingBurger pbj = new TRexKingBurger();
            pbj.HoldOnion();
            pbj.HoldPickle();
            pbj.HoldLettuce();
            pbj.HoldMustard();
            pbj.HoldMayo();

            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Pickles", item);
                },
                 item =>
                 {
                     Assert.Equal("Hold Mustard", item);
                 },
                 item =>
                 {
                     Assert.Equal("Hold Lettuce", item);
                 },
                 item =>
                 {
                     Assert.Equal("Hold Mayo", item);
                 },
                 item =>
                 {
                     Assert.Equal("Hold Onion", item);
                 }



                );
        }



    }

}
