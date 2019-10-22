using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class DinoNuggetsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            DinoNuggets d = new DinoNuggets();
            Assert.Equal(4.25, d.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            DinoNuggets d = new DinoNuggets();
            Assert.Equal<uint>(59 * 6, d.Calories);
        }


        [Fact]
        public void ShouldListDefaultIngredients()
        {
            DinoNuggets d = new DinoNuggets();
            List<string> ingredients = d.Ingredients;
           
            int nuggetCount = 0;
            foreach (string i in ingredients)
            {
                if (i.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(6, nuggetCount);
            Assert.Equal<int>(6, ingredients.Count);
        }

        [Fact]
        public void AddingNuggetsShouldAddIngredients()
        {
            DinoNuggets d = new DinoNuggets();
            d.AddNugget();
            int nuggetCount = 0;
            foreach (string i in d.Ingredients)
            {
                if (i.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(7, nuggetCount);
            Assert.Equal<int>(7, d.Ingredients.Count);

            d.AddNugget();

            nuggetCount = 0;
            foreach (string ingredient in d.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(8, nuggetCount);
            Assert.Equal<int>(8, d.Ingredients.Count);

        }

        [Fact]
        public void AddingNuggetsShouldIncreasePrice()
        {
            DinoNuggets d = new DinoNuggets();
            d.AddNugget();
            Assert.Equal(4.50, d.Price);
            d.AddNugget();
            Assert.Equal(4.75, d.Price);
            d.AddNugget();
            Assert.Equal(5.0, d.Price);
        }

        [Fact]
        public void AddingNuggetsShouldIncreaseCalories()
        {
            DinoNuggets d = new DinoNuggets();
            d.AddNugget();
            Assert.Equal<uint>(59 * 7, d.Calories);
            d.AddNugget();
            Assert.Equal<uint>(59 * 8, d.Calories);
            d.AddNugget();
            Assert.Equal<uint>(59 * 9, d.Calories);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            DinoNuggets d = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", d.Description);
        }

        [Fact]
        public void SpecialShouldNotbeEmptyByDefault()
        {
            DinoNuggets d = new DinoNuggets();
            Assert.Contains("0 Extra Nuggets", d.Special);
        }

        [Fact]
        public void AddingNuggetsShouldChangeSpecial()
        {
            DinoNuggets d = new DinoNuggets();
            d.AddNugget();
            d.AddNugget();
            d.AddNugget();
            d.AddNugget();
            d.AddNugget();
            Assert.Collection<string>(d.Special, item =>
            {
                Assert.Equal("5 Extra Nuggets", item);
            });
        }
    }
}