using System;

namespace DinoDiner.Menu.Entree
{
    public class Brontowurst
    {
        private List<string> ingredients = new List<string>();
        private double price;
        private unit calories;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public List<string> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public unit Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public Brontowurst()
        {
            this.Calories = 498;
            this.Price = 5.36;
            this.Ingredients = new List<string>("brautwurst", "whole-wheat bun", "peppers", "onions");
        }

    public void Bun();
    public void Pepper();
    public void onions();

    }
}
