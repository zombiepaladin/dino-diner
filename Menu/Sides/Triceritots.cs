using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        /// <summary>
        /// Represents size of tots
        /// </summary>
        private Size size;

        /// <summary>
        /// Sets and gets the size of tots
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;



                }



            }
            get { return size; }

        }
        /// <summary>
        /// Creates tots
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;

        }


        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            switch (size)
            {
                case Size.Small:
                    item.Append("Small ");

                    break;
                case Size.Medium:
                    item.Append("Medium ");

                    break;
                case Size.Large:
                    item.Append("Large ");

                    break;
                default:
                    break;


            }
            item.Append("Triceritots");
            return item.ToString();
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");

                return ingredients;




            }
        }
    }
}