using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Represents the size of mezzorella sticks
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets and sets the size of mezzorella sticks
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;



                }



            }
            get { return size; }

        }

        /// <summary>
        /// Creates the mezzorella sticks
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            
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
            item.Append("Mezzorella Sticks");
            return item.ToString();
        }
         public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                Ingredients.Add("Cheese Product");
                Ingredients.Add("Breading");
                Ingredients.Add("Vegetable Oil");

                return ingredients;
            }
        }
    }
}
