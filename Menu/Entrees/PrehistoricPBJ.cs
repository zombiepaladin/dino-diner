 using System.Collections.Generic;

namespace DinoDiner.Menu
{



    
    /// <summary>
    /// This class is for the PrehistoricPBJ and is used to setup and modify it
    /// </summary>
    public class PrehistoricPBJ : Entree
    {


        private bool bun = true;
        private bool peanutButter = true;
        private bool jelly = true;
        private List<string> ingredients;



        public override double Price
        {
            get
            {
                return 6.52;
            }
        }

        public override uint Calories
        {
            get
            {
                return 483;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Bread");
                
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }


        }




        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Sets base price, Calories, and Ingredients for PrehistoricPBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            
           
            ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
        }
        /// <summary>
        /// Holds the Peanut Butter from the PrehistoricPBJ
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
            this.Ingredients.Remove("Peanut Butter");
        }
        /// <summary>
        /// Holds the Jelly from the PrehistoricPBJ
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
            this.Ingredients.Remove("Jelly");
        }
    }
}
