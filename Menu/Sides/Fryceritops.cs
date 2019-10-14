using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
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
        /// Used to print the name for combos
        /// </summary>
        /// <returns>The name of Item for menu</returns>
        public override string ToString()
        {
            if(size == Size.Large)
            {
                return "Large Fryceritops";
            }
            if (size == Size.Medium)
            {
                return "Medium Fryceritops";
            }
            
                return "Small Fryceritops";
            

        }

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
                       // ToString("Large");
                        base.Size = value;
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                       // ToString() = "hello";
                        base.Size = value;
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                       // ToString("Small");
                        base.Size = value;
                        Price =.99;
                        Calories = 222;
                        break;
                }
            }



        }





    }
}

