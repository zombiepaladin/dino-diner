﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        NotifyIfPropertyChanged("Description");
                        NotifyIfPropertyChanged("Price");
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
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");

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
            item.Append("Fryceritops");
            return item.ToString();
        }

        

    }
}
