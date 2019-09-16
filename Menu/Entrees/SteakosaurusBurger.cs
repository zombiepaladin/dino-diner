using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{

    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool mustard = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool tomato = true;
        private bool onion = true;
        private bool lettuce = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public SteakosaurusBurger()
        {
            this.Calories = 621;
            this.Price = 5.15;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Steak Burger" };
                if (pickle) ingredients.Add("Pickle");
                if (mustard) ingredients.Add("Mustard");
                if (ketchup) ingredients.Add("Ketchup");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (lettuce) ingredients.Add("Lettuce");
                return ingredients;
            }

        }


        public void HoldBun()
        {
            this.bun = false;

        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}

