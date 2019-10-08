using System.Collections.Generic;
using DinoDiner.Menu.Entrees;
namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {
     
  

        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                
                return ingredients;
            }
        }

        /// <summary>
        /// Initial price and calories of wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        public override string ToString()
        {
            return ("Pterodactyl Wings");
        }
    }
}
