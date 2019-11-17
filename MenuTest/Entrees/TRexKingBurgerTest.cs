using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.Equal(8.45, t.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.Equal<uint>(728, t.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger t = new TRexKingBurger();
            List<string> ingredients = t.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach (string ingredient in ingredients)
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
            TRexKingBurger t = new TRexKingBurger();
            t.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", t.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", t.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", t.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldOnion();
            Assert.DoesNotContain<string>("Onion", t.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", t.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", t.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", t.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", t.Ingredients);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", t.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.Empty(t.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldBun();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Whole Wheat Bun", item);
            });
        }

        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldLettuce();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            });
        }

        [Fact]
        public void HoldOnionShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldOnion();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            });
        }

        [Fact]
        public void HoldTomatoShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldTomato();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Tomato", item);
            });
        }

        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldPickle();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }

        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldKetchup();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldMustard();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldMayoShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldMayo();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Mayo", item);
            });
        }

        [Fact]
        public void HoldAllComponentsShouldAddToSpecial()
        {
            TRexKingBurger t = new TRexKingBurger();
            t.HoldBun();
            t.HoldLettuce();
            t.HoldOnion();
            t.HoldTomato();
            t.HoldPickle();
            t.HoldKetchup();
            t.HoldMustard();
            t.HoldMayo();
            Assert.Collection<string>(t.Special, item =>
            {
                Assert.Equal("Hold Whole Wheat Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Lettuce", item);
            },
            item =>
            {
                Assert.Equal("Hold Onion", item);
            },
            item =>
            {
                Assert.Equal("Hold Tomato", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickle", item);
            },
            item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            },
            item =>
            {
                Assert.Equal("Hold Mayo", item);
            });
        }

        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldBun();
            });
        }

        [Fact]
        public void HoldingLettuceShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldLettuce();
            });
        }

        [Fact]
        public void HoldingOnionShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldOnion();
            });
        }

        [Fact]
        public void HoldingTomatoShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldTomato();
            });
        }

        [Fact]
        public void HoldingPickleShouldNotifySpecialChange()
        {
            SteakosaurusBurger t = new SteakosaurusBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldPickle();
            });
        }

        [Fact]
        public void HoldingKetchupShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldKetchup();
            });
        }

        [Fact]
        public void HoldingMustardShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldMustard();
            });
        }

        [Fact]
        public void HoldingMayoShouldNotifySpecialChange()
        {
            TRexKingBurger t = new TRexKingBurger();
            Assert.PropertyChanged(t, "Special", () =>
            {
                t.HoldMayo();
            });
        }

    }

}