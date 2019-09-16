using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{


    /// <summary>
    /// This class is for the SteakosaurusBurger and is used to setup and modify it
    /// </summary>
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool pattie = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;


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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// This sets the price and calories
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// this is used to hold the item
        public void HoldBun()
        {
            this.bun = false;
        }
        /// this is used to hold the item
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// this is used to hold the item
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// this is used to hold the item
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
