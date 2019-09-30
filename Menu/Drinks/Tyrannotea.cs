using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drinks
    {
      

        public Tyrannotea()
        {

            this.Calories = 8;
            this.Ingredients = new List<string>() { "Water", "Tea" };
            this.Price = 0.99;
           


        }
        public bool Sweet = false;
        public bool Lemon = false;
        public bool Ice = false;


        public Size size;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {

                size = value;

                if (size == Size.Small)
                {
                    Price = 0.99;
                    this.Calories = 8;
                }
                else if (size == Size.Medium)
                {
                    Price = 1.49;
                    this.Calories = 16;
                }
                else if (size == Size.Large)
                {
                    Price = 1.99;
                    this.Calories = 32;
                }

            }

        }
        public void AddLemon()
        {
            Ingredients.Add("Lemon");

            Lemon = true;


        }
        public void AddSweet()
        {
            Ingredients.Add("Cane Sugar");
            this.Calories = this.Calories * 2;

            Sweet = true;


        }
        public void AddIce()
        {
            Ice = true;
            
        }

    }
}
