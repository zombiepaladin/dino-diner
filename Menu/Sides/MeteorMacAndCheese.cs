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
        private List<string> ingredients;



        public override double Price
        {
            get
            {
                if (size == Size.Large) return 1.95;
                if (size == Size.Medium) return 1.45;
                return .99;
            }
        }

        public override uint Calories
        {
            get
            {
                if (size == Size.Large) return 520;
                if (size == Size.Medium) return 490;
                return 420;
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                
                List<string> ingredients = new List<string>();

                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");


                return ingredients;
            }


        }
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


           
            ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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
