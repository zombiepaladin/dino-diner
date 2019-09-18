using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {

        public  Size size;
        public override Size()
        {

            set {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Small:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }




        }


        public Fryceritops()
        {

            /*Case(this.Size){

            }*/
            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegtable Oil" };
        }
        
       

    }
}
