using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        
        private Size size;

        public bool Lemon { get; set; } = false;

        public bool Sweet { get; set; } = false;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;



                }



            }
            get { return size; }

        }

        public void AddLemon()
        {
            Lemon = true;
        }
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
            if (Lemon) Ingredients.Add("Lemon");
            if(Sweet)
            {
                Ingredients.Add("Cane Sugar");
                switch (size)
                {
                    case Size.Small:
                        
                        Calories = 16;
                        break;
                    case Size.Medium:
                       
                        Calories = 32;
                        break;
                    case Size.Large:
                        
                        Calories = 64;
                        break;



                }
            }
                

        }
    }
}
