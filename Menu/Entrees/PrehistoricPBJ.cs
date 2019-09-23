using System.Collections.Generic;
using DinoDiner.Menu.Entrees;
namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Represents whether or not peanutButter is added to PBJ
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Represents whether or not jelly is added to PBJ
        /// </summary>
        private bool jelly = true;

        
        /// <summary>
        /// Creates the PBJ
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Initial price of PBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Called when PeanutButter is withheld
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// Called when jelly is withheld
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
