using System.Collections.Generic;

namespace DinoDiner.Menu
{


    /// <summary>
    /// This class is for the SteakosaurusBurger and is used to setup and modify it
    /// </summary>
    public class SteakosaurusBurger : Entree
    {



        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
        /// <summary>
        /// Sets base price, Calories, and Ingredients for SteakosaurusBurger
        /// </summary>
        public SteakosaurusBurger()
        {
           
            this.Ingredients = new List<string>() { "Steakburger Pattie", "Whole Wheat Bun", "Pickle", "Ketchup", "Mustard" };
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Holds the bun from the SteakosaurusBurger
        /// </summary>
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// Holds the Pickle from the SteakosaurusBurger
        /// </summary>
        public void HoldPickle()
        {
            this.Ingredients.Remove("Pickle");
        }
        /// <summary>
        /// Holds the Ketchup from the SteakosaurusBurger
        /// </summary>
        public void HoldKetchup()
        {
            this.Ingredients.Remove("Ketchup"); ;
        }
        /// <summary>
        /// Holds the Mustard from the SteakosaurusBurger
        /// </summary>
        public void HoldMustard()
        {
            this.Ingredients.Remove("Mustard");
        }
    }
}
