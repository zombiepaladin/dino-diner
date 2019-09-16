using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// THis class is for the DinoNuggets and is used to setup and modify it
    /// </summary>
    public class DinoNuggets
    {
        private bool nuggets = true;

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
                List<string> ingredients = new List<string>() { "Chicken Nugget" };
                for(int i = 0; i < 5; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }

                return ingredients;
            }
        }

        /// This sets the price and calories
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
        }
        /// this is used to add one nugget
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            
        }




    }
}
