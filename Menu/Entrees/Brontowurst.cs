using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool onions = true;
        private bool bun = true;
        private bool peppers = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (onions) ingredients.Add("Onions");
                if (peppers) ingredients.Add("Peppers");
                if (bun) ingredients.Add("Bun");
                return ingredients;
            }
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}

