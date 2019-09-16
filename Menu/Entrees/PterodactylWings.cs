using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{


    /// <summary>
    /// This class is for the PterodactylWings and is used to setup and modify it
    /// </summary>
    public class PterodactylWings
    {
        private bool chicken = true;
        private bool wingSauce = true;



        /// <summary>
        /// gets and sets price and calories
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }



        // this is the list of Ingredients
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                if (wingSauce) ingredients.Add("Wing Sauce");
                
                return ingredients;
            }
        }

        /// This sets the price and calories
        public PterodactylWings()
        {
            this.Price    = 7.21;
            this.Calories = 318;
        }

    }
}
