 using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{

    /// <summary>
    /// This class is for the PrehistoricPBJ and is used to setup and modify it
    /// </summary>
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;


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
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// This sets the price and calories
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// this is used to hold the item
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// this is used to hold the item
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
