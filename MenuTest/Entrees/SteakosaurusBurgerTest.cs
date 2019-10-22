using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Equal(5.15, s.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Equal<uint>(621, s.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            List<string> ingredients = s.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", s.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", s.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", s.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", s.Ingredients);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", s.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.Empty(s.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Whole Wheat Bun", item);
            });
        }

        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldPickle();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            });
        }

        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldKetchup();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldBunPickleKetchupMustrardShouldAddToSpecial()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            s.HoldBun();
            s.HoldPickle();
            s.HoldKetchup();
            s.HoldMustard();
            Assert.Collection<string>(s.Special, item =>
            {
                Assert.Equal("Hold Whole Wheat Bun", item);
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
            });
        }

        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldBun();
            });
        }

        [Fact]
        public void HoldingPickleShouldNotifySpecialChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldPickle();
            });
        }

        [Fact]
        public void HoldingKetchupShouldNotifySpecialChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldKetchup();
            });
        }

        [Fact]
        public void HoldingMustardShouldNotifySpecialChange()
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldMustard();
            });
        }
    }

}