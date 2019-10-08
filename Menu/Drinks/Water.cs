using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public bool Lemon { get; set; } = false;

        
        private Size size;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = .1;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = .1;
                        Calories = 0;
                        break;



                }



            }
            get { return size; }

        }

        public void AddLemon()
        {
            Lemon = true;
        }

        
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ingredients.Add("Water");
            if (Lemon) Ingredients.Add("Lemon");
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
            item.Append("Water");
            return item.ToString();
        }
    }
}
