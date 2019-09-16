using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {

        public double Price { get; set; }

        public uint Calories { get; set; }

        private bool addNugget = false;

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "6 Chicken Nuggets" };
                return ingredients;
            }
        }

        public void AddNugget()
        {
            if (addNugget == true)
            {
                Price = Price + .25;
                Calories = Calories + 59;
            }
        }



        public void Nugget()
        {
            this.addNugget = true;
        }
    }
}

