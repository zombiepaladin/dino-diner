using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{


    /// <summary>
    /// This class is for the TRexKingBurger and is used to setup and modify it
    /// </summary>
    public class TRexKingBurger
    {
        private bool bun = true;
        private bool patties = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;




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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" , };
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie"); 
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// This sets the price and calories
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// this is used to hold the item
        public void HoldBun()
        {
            this.bun = false;
        }
        /// this is used to hold the item
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// this is used to hold the item
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// this is used to hold the item
        public void HoldOnion()
        {
            this.onion = false;
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
        /// this is used to hold the item
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
