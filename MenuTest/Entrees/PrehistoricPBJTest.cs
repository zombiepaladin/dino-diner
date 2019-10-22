using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            Assert.Equal(6.52, p.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            Assert.Equal<uint>(483, p.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            List<string> ingredients = p.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            p.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", p.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            p.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", p.Ingredients);
        }

        //Start of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", p.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            Assert.Empty(p.Special);
        }

        [Fact]
        public void HoldPeanutButterShouldAddToSpecial()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            p.HoldPeanutButter();
            Assert.Collection<string>(p.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            });
        }

        [Fact]
        public void HoldJellyShouldAddToSpecial()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            p.HoldJelly();
            Assert.Collection<string>(p.Special, item =>
            {
                Assert.Equal("Hold Jelly", item);
            });
        }

        [Fact]
        public void HoldPeanutButterAndJellyShouldAddToSpecial()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            p.HoldPeanutButter();
            p.HoldJelly();
            Assert.Collection<string>(p.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            },
            item =>
            {
                Assert.Equal("Hold Jelly", item);
            });
        }

        [Fact]
        public void HoldingPeanutButterShouldNotifySpecialChange()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            Assert.PropertyChanged(p, "Special", () =>
            {
                p.HoldPeanutButter();
            });
        }

        [Fact]
        public void HoldingJellyShouldNotifySpecialChange()
        {
            PrehistoricPBJ p = new PrehistoricPBJ();
            Assert.PropertyChanged(p, "Special", () =>
            {
                p.HoldJelly();
            });
        }
    }

}