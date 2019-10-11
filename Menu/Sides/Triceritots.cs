using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Class for the side Triceritots
    /// </summary>
    public class Triceritots : Side
    {



        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            if (size == Size.Large)
            {
                return "Large Triceritots";
            }
            if (size == Size.Medium)
            {
                return "Medium Triceritots";
            }

            return "Small Triceritots";


        }



        /// <summary>
        /// This defigns the price, calories, and Ingredients of  Triceritots

        /// </summary>
        public Triceritots()
        {


            this.Price = 0.99;
            this.Calories = 352;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }

        /// <summary>
        /// variable to accsess Size
        /// </summary>
        public Size size;

        /// <summary>
        /// Checks to see what size of side then add the new price and calories
        /// </summary>
        public override Size Size
        {

            set
            {

                size = value;
                switch (size)
                {

                    case Size.Large:
                        base.Size = value;
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        base.Size = value;
                        Price = 1.45;
                        Calories = 410;
                        break;

                }
            }



        }

    }
}