using System.Collections.Generic;

namespace DinoDiner.Menu
{


    /// <summary>
    /// This class is for the PterodactylWings and is used to setup and modify it
    /// </summary>
    public class PterodactylWings : Entree
    {


        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Sets base price, Calories, and Ingredients for PterodactylWings
        /// </summary>
        public PterodactylWings()
        {
            this.Price    = 7.21;
            this.Calories = 318;
            this.Ingredients = new List<string>() { "Chicken", "Wing Sauce" };
        }

    }
}
