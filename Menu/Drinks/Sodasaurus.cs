using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    

    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Gets or sets 
        /// </summary>
        /// 
        public SodasaurusFlavor Flavor { get; set; }

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



            }
            get { return size; }

        }

        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            
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
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                Ingredients.Add("Water");
                Ingredients.Add("Natural Flavors");
                Ingredients.Add("Cane Sugar");

                return ingredients;
            }
        }
    }
}
