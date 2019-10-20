using System.Collections.Generic;

namespace DinoDiner.Menu
{


    /// <summary>
    /// This class is for the PterodactylWings and is used to setup and modify it
    /// </summary>
    public class PterodactylWings : Entree, IOrderItem
    {

        
        private List<string> ingredients;



        public override double Price
        {
            get
            {
                return 7.21;
            }
        }

        public override uint Calories
        {
            get
            {
                return 318;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                
                return ingredients;
            }


        }

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
          
            ingredients = new List<string>() { "Chicken", "Wing Sauce" };
        }

    }
}
