using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class is for the DinoNuggets and is used to setup and modify it
    /// </summary>
    public class DinoNuggets : Entree
    {
       


        /// <summary>
        /// Sets base price, Calories, and Ingredients for DinoNuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
            this.Ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" , "Chicken Nugget" };
        }
        /// <summary>
        /// Adds an extra nugget to the meal and adds price and Calories of that one nugget 
        /// </summary>
        public void AddNugget()
        {


            this.Ingredients.Add( "Chicken Nugget");
            this.Price += .25;
            this.Calories += 59;
            
        }




    }
}
