﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {

        /// <summary>
        /// represents size of fryceritops
        /// </summary>
        private Size size;
        /// <summary>
        /// gets and sets the size of frys
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;



                }



            }
            get { return size; }

        }
        /// <summary>
        /// Creates the fryceritops
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            Ingredients.Add("Potato");
            Ingredients.Add("Salt");
            Ingredients.Add("Vegetable Oil");
        }

    }
}
