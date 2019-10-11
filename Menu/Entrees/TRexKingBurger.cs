using System.Collections.Generic;

namespace DinoDiner.Menu
{


    /// <summary>
    /// This class is for the TRexKingBurger and is used to setup and modify it
    /// </summary>
    public class TRexKingBurger : Entree
    {

        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }


        /// <summary>
        /// Sets base price, Calories, and Ingredients for TRexKingBurger
        /// </summary>
        public TRexKingBurger()
        {
            this.Ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie", "Whole Wheat Bun", "Lettuce","Tomato","Onion","Pickle", "Ketchup", "Mustard", "Mayo" };
            this.Price = 8.45;
            this.Calories = 728;
        }
         
        public void HoldBun()
        {
            this.Ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// Holds the Lettuce from the TRexKingBurger
        /// </summary>
        public void HoldLettuce()
        {
            this.Ingredients.Remove("Lettuce");
        }
        /// <summary>
        /// Holds the Tomato from the TRexKingBurger
        /// </summary>
        public void HoldTomato()
        {
            this.Ingredients.Remove("Tomato");
        }
        /// <summary>
        /// Holds the Onion from the TRexKingBurger
        /// </summary>
        public void HoldOnion()
        {
            this.Ingredients.Remove("Onion");
        }
        /// <summary>
        /// Holds the Pickle from the TRexKingBurger
        /// </summary>
        public void HoldPickle()
        {
            this.Ingredients.Remove("Pickle");
        }
        /// <summary>
        /// Holds the Ketchup from the TRexKingBurger
        /// </summary>
        public void HoldKetchup()
        {
            this.Ingredients.Remove("Ketchup");
        }
        /// <summary>
        /// Holds the Mustard from the TRexKingBurger
        /// </summary>
        public void HoldMustard()
        {
            this.Ingredients.Remove("Mustard");
        }
        /// <summary>
        /// Holds the Mayo from the TRexKingBurger
        /// </summary>
        public void HoldMayo()
        {
            this.Ingredients.Remove("Mayo");
        }
    }
}
