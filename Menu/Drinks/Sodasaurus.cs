using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DinoDiner.Menu.Drinks;

/*Sodasaurus.cs
 * Author: Thomas Paul
 */
namespace DinoDiner.Menu.Drinks
{
    

    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Private enum for all the flavors of soda
        /// </summary>
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        private Size size;

        

        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;



                }
                NotifyIfPropertyChanged("Description");
                NotifyIfPropertyChanged("Price");


            }
            get { return size; }

        }

        /// <summary>
        /// Creates sodasaurus object
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");

        }

        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            switch (size)
            {
                case Size.Small:
                    item.Append("Small ");
                    switch(Flavor)
                    {
                        case SodasaurusFlavor.Cherry:
                            item.Append("Cherry ");
                            break;
                        case SodasaurusFlavor.Lime:
                            item.Append("Lime ");
                            break;
                        case SodasaurusFlavor.Cola:
                            item.Append("Cola ");
                            break;
                        case SodasaurusFlavor.Vanilla:
                            item.Append("Vanilla ");
                            break;
                        case SodasaurusFlavor.RootBeer:
                            item.Append("RootBeer ");
                            break;
                        case SodasaurusFlavor.Chocolate:
                            item.Append("Chocolate ");
                            break;
                        case SodasaurusFlavor.Orange:
                            item.Append("Orange ");
                            break;

                    }
                    break;   
                  
                case Size.Medium:
                    item.Append("Medium ");
                    switch (Flavor)
                    {
                        case SodasaurusFlavor.Cherry:
                            item.Append("Cherry ");
                            break;
                        case SodasaurusFlavor.Lime:
                            item.Append("Lime ");
                            break;
                        case SodasaurusFlavor.Cola:
                            item.Append("Cola ");
                            break;
                        case SodasaurusFlavor.Vanilla:
                            item.Append("Vanilla ");
                            break;
                        case SodasaurusFlavor.RootBeer:
                            item.Append("RootBeer ");
                            break;
                        case SodasaurusFlavor.Chocolate:
                            item.Append("Chocolate ");
                            break;
                        case SodasaurusFlavor.Orange:
                            item.Append("Orange ");
                            break;

                    }
                    break;
                case Size.Large:
                    item.Append("Large ");
                    switch (Flavor)
                    {
                        case SodasaurusFlavor.Cherry:
                            item.Append("Cherry ");
                            break;
                        case SodasaurusFlavor.Lime:
                            item.Append("Lime ");
                            break;
                        case SodasaurusFlavor.Cola:
                            item.Append("Cola ");
                            break;
                        case SodasaurusFlavor.Vanilla:
                            item.Append("Vanilla ");
                            break;
                        case SodasaurusFlavor.RootBeer:
                            item.Append("RootBeer ");
                            break;
                        case SodasaurusFlavor.Chocolate:
                            item.Append("Chocolate ");
                            break;
                        case SodasaurusFlavor.Orange:
                            item.Append("Orange ");
                            break;

                    }
                    break;
                default:
                    
                    break;



            }
            item.Append("Sodasaurus");
            return item.ToString();

        }
        

        
        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

    }
}
