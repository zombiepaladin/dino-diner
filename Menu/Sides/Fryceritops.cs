using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class for the side Fryceritops
    /// </summary>
    public class Fryceritops : Side
    {


        /// <summary>
        /// This defigns the price, calories, and Ingredients of Fryceritops
        /// </summary>
        public Fryceritops()
        {
          
           

            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            
        }
        /// <summary>
        /// variable to accsess Size
        /// </summary>
        public Size size;

        /// <summary>
        /// Checks to see what size of side then add the new price and calories
        /// </summary>
        public  override Size Size
        {
             
            set {
               
                size = value;
               
                switch (size)
                {
                    
                    case Size.Large:

                        base.Size = value;
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        base.Size = value;
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        base.Size = value;
                        Price =.99;
                        Calories = 222;
                        break;
                }
            }



        }





    }
}

