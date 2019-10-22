using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap v = new VelociWrap();
            Assert.Equal(6.86, v.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap v = new VelociWrap();
            Assert.Equal<uint>(356, v.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap v = new VelociWrap();
            List<string> ingredients = v.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap v = new VelociWrap();
            v.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", v.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap v = new VelociWrap();
            v.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", v.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", v.Ingredients);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            VelociWrap v = new VelociWrap();
            Assert.Equal("Veloci-Wrap", v.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            VelociWrap v = new VelociWrap();
            Assert.Empty(v.Special);
        }

        [Fact]
        public void HoldDressingShouldAddToSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldDressing();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Ceasar Dressing", item);
            });
        }

        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldLettuce();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Romaine Lettuce", item);
            });
        }

        [Fact]
        public void HoldCheeseShouldAddToSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Parmesan Cheese", item);
            });
        }

        [Fact]
        public void HoldAllComponentsShouldAddToSpecial()
        {
            VelociWrap v = new VelociWrap();
            v.HoldDressing();
            v.HoldLettuce();
            v.HoldCheese();

            Assert.Collection<string>(v.Special, item =>
            {
                Assert.Equal("Hold Ceasar Dressing", item);
            },
            item =>
            {
                Assert.Equal("Hold Romaine Lettuce", item);
            },
            item =>
            {
                Assert.Equal("Hold Parmesan Cheese", item);
            });
        }

        [Fact]
        public void HoldingDressingShouldNotifySpecialChange()
        {
            VelociWrap v = new VelociWrap();
            Assert.PropertyChanged(v, "Special", () =>
            {
                v.HoldDressing();
            });
        }

        [Fact]
        public void HoldingLettuceShouldNotifySpecialChange()
        {
            VelociWrap v = new VelociWrap();
            Assert.PropertyChanged(v, "Special", () =>
            {
                v.HoldLettuce();
            });
        }

        [Fact]
        public void HoldingCheeseShouldNotifySpecialChange()
        {
            VelociWrap v = new VelociWrap();
            Assert.PropertyChanged(v, "Special", () =>
            {
                v.HoldCheese();
            });
        }

    }
}