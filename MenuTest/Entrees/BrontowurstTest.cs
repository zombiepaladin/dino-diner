using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialChanged()
        {
            Brontowurst pbj = new Brontowurst();

            Assert.PropertyChanged(pbj, "Special", () => { pbj.HoldOnion(); });
            
        }

        [Fact]
        public void HoldPepperShouldNotifyOfSpecialChanged()
        {
            Brontowurst pbj = new Brontowurst();

            Assert.PropertyChanged(pbj, "Special", () => {
                pbj.HoldPeppers();
            });
        }


        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {

            Brontowurst pbj = new Brontowurst();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            Brontowurst pbj = new Brontowurst();
            pbj.HoldOnion();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                }



                );
        }



        [Fact]
        public void SpecialShouldHoldPepper()
        {
            Brontowurst pbj = new Brontowurst();
            pbj.HoldPeppers();
            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                }



                );
        }

        [Fact]
        public void SpecialShouldHoldAll()
        {
            Brontowurst pbj = new Brontowurst();
            pbj.HoldOnion();
            pbj.HoldPeppers();

            Assert.Collection<string>(pbj.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                }



                );
        }




    }

}
