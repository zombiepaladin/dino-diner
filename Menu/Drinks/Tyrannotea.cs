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
                        if (Sweet) Calories = 16;
                        else Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet) Calories = 32;
                        else Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        if (Sweet) Calories = 64;
                        else Calories = 32;
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
            
            if (Lemon) Ingredients.Add("Lemon");
            if (Sweet)
            {
                Ingredients.Add("Cane Sugar");
                
            }
           


        }
        public override string ToString()
        {
            StringBuilder item = new StringBuilder();
            switch (size)
            {
                case Size.Small:
                    item.Append("Small ");
                    if (Sweet)
                    {
                        item.Append("Sweet ");
                    }
                    break;
                case Size.Medium:
                    item.Append("Medium ");
                    if (Sweet)
                    {
                        item.Append("Sweet ");
                    }
                    break;
                case Size.Large:
                    item.Append("Large ");
                    if (Sweet)
                    {
                        item.Append("Sweet ");
                    }
                    break;
                default:
                    break;


            }
            item.Append("Tyrannotea");
            return item.ToString();

        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                
                Ingredients.Add("Water");
                Ingredients.Add("Tea");
                if (Lemon) Ingredients.Add("Lemon");
                if (Sweet)
                {
                    Ingredients.Add("Cane Sugar");
                }
                   
                
                return ingredients;
            }
        }
    }
}
