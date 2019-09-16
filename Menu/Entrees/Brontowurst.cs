using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{

    /// <summary>
    /// THis class is for the brawtwurst and is used to setup and modify it
    /// </summary>
    public class Brontowurst
    {
        private bool brautwurst = true;
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;


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
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                
                return ingredients;
            }
        }

        /// This sets the price and calories
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// this is used to hold the item
        public void HoldBun()
        {
            this.bun = false;
        }
        /// this is used to hold the item
        public void HoldOnion()
        {
            this.onions = false;
        }
        /// this is used to hold the item
        public void HoldPeppers()
        {
            this.peppers = false;
        }
    }
}
