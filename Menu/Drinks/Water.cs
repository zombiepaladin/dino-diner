using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{

    /// <summary>
    /// THis calls is for water and is used to modify or change the water
    /// </summary>
    public class Water : Drinks
    {
        /// <summary>
        /// THis is to indicate wether a lemon is in the drink by default
        /// </summary>
        public bool Lemon = false;

        /// <summary>
        /// This is to indicate if ice is in the drink by default
        /// </summary>
        public bool Ice = true;

        /// <summary>
        /// This is the water constructor to setup def Cal.,Ing., and Price.
        /// </summary>
        public Water()
        {

            this.Calories = 0;
            this.Ingredients = new List<string>() { "Water" };
            this.Price = 0.10;
            

        }



        /// <summary>
        /// Sets up a variable of type Size to access the Size class
        /// </summary>
        public Size size;

        /// <summary>
        /// Public getter and setter for Size
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {

                size = value;



                Price = .10;
                this.Calories = 0;



            }

        }
        /// <summary>
        /// This method Adds lemon to the drink
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            this.Ingredients.Add("Lemon");


        }

        /// <summary>
        /// This method Removes the ice from the drink
        /// </summary>
        /// <returns>THis returns a false to show that there is no ice</returns>
        public override bool HoldIce()
        {
            Ice = false;
            return false;

        }
    }
}
