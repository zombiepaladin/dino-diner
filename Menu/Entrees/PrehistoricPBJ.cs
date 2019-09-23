 using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{

    /// <summary>
    /// This class is for the PrehistoricPBJ and is used to setup and modify it
    /// </summary>
    public class PrehistoricPBJ : Entree
    {



        /// <summary>
        /// Sets base price, Calories, and Ingredients for PrehistoricPBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            this.Ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
        }
        /// <summary>
        /// Holds the Peanut Butter from the PrehistoricPBJ
        /// </summary>
        public void HoldPeanutButter()
        {
            this.Ingredients.Remove("Peanut Butter");
        }
        /// <summary>
        /// Holds the Jelly from the PrehistoricPBJ
        /// </summary>
        public void HoldJelly()
        {
            this.Ingredients.Remove("Jelly");
        }
    }
}
