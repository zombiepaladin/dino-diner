using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        private bool chicken = true;
        private bool wingSauce = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                if (wingSauce) ingredients.Add("Wing Sauce");
                
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price    = 7.21;
            this.Calories = 318;
        }

    }
}
