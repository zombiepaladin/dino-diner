using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{

    /// <summary>
    /// Class for the side MezzorellaSticks
    /// </summary>
    public class MezzorellaSticks : Side
    {

        /// <summary>
        /// This defigns the price, calories, and Ingredients of  MezzorellaSticks

        /// </summary>
        public MezzorellaSticks()
        {


            this.Price = 0.99;
            this.Calories = 540;
            this.Ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
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
                        Calories = 720;
                        break;
                    case Size.Medium:
                        base.Size = value;
                        Price = 1.45;
                        Calories = 610;
                        break;
                    
                }
            }



        }

    }
}
