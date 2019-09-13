using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class PterodactylWings
    {

        private bool chicken = true;


        private bool jelly = true;

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        
    }
}
