using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        
      
        /// <summary>
        /// Represents the number of nuggets
        /// </summary>
        public int Count = 6;

        /// <summary>
        /// Creates the order of dino nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {  };
                for(int i = 0; i < Count; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Initial price and calories of dino nugget
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// Called when nugget is added
        /// </summary>
        public void AddNugget()
        {
            this.Price += 0.25;
            this.Calories += 59;
            Count++;
        }
        public override string ToString()
        {
            return ("Dino-Nuggets");
        }
    }
    }
