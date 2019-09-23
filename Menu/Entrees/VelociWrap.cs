using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{


    /// <summary>
    /// This class is for the VelociWrap and is used to setup and modify it
    /// </summary>
    public class VelociWrap : Entree
    {

        /// <summary>
        /// Sets base price, Calories, and Ingredients for VelociWrap
        /// </summary>
        public VelociWrap()
        {
         
            this.Ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Romaine Lettuce", "Ceasar Dressing", "Parmesan Cheese" };
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Used to hold the dressing
        /// </summary>
        public void HoldDressing()
        {
            this.Ingredients.Remove("Ceasar Dressing");
        }
        /// <summary>
        /// Used to Hold the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.Ingredients.Remove("Romaine Lettuce");
        }
        /// <summary>
        /// Used to hold the cheese
        /// </summary>
        public void HoldCheese()
        { 
            this.Ingredients.Remove("Parmesan Cheese");
        }
    }
}
