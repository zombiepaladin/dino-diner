using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{

    /// <summary>
    /// THis class is for the brawtwurst and is used to setup and modify it
    /// </summary>
    public class Brontowurst : Entree
    {


        /// <summary>
        /// Sets base price, Calories, and Ingredients for Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
            this.Ingredients = new List<string>() { "Brautwurst", "Whole Wheat Bun", "Peppers","Onion"};
        }

        /// this is used to hold the item
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }
        /// this is used to hold the item
        public void HoldOnion()
        {
            this.Ingredients.Remove("Onion");
        }
        /// this is used to hold the item
        public void HoldPeppers()
        {
            
            this.Ingredients.Remove("Peppers");
        }
    }
}
