using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the side MeteorMacAndCheese
    /// </summary>
    public class MeteorMacAndCheese : Side
    {

        /// <summary>
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            if (size == Size.Large)
            {
                return "Large Meteor Mac and Cheese";
            }
            if (size == Size.Medium)
            {
                return "Medium Meteor Mac and Cheese";
            }

            return "Small Meteor Mac and Cheese";


        }


        /// <summary>
        /// This defigns the price, calories, and Ingredients of MeteorMacAndCheese
        /// </summary>
        public MeteorMacAndCheese()
        {


            this.Price = 0.99;
            this.Calories = 420;
            this.Ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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
                        Calories = 520;
                        break;
                    case Size.Medium:
                        base.Size = value;
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        base.Size = value;
                        Price = .99;
                        Calories = 420;
                        break;
                }
            }



        }

    }

}
