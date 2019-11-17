using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class PterodactylWingsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PterodactylWings p = new PterodactylWings();
            Assert.Equal(7.21, p.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PterodactylWings p = new PterodactylWings();
            Assert.Equal<uint>(318, p.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PterodactylWings p = new PterodactylWings();
            List<string> ingredients = p.Ingredients;
            Assert.Contains<string>("Chicken", ingredients);
            Assert.Contains<string>("Wing Sauce", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            PterodactylWings p = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", p.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            PterodactylWings p = new PterodactylWings();
            Assert.Empty(p.Special);
        }

    }
}