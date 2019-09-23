using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace Menu.Entrees
{
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Represents the existence of bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Represents the existence of pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Represents the existence of ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Represents the existence of mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Represents the existence of lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Represents the existence of onion
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Represents the existence of mayo
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// Represents the existence of tomato
        /// </summary>
        private bool tomato = true;

       
        /// <summary>
        /// Creates the T-Rex Burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (lettuce) ingredients.Add("Lettuce");
                if (onion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");
                if (tomato) ingredients.Add("Tomato");
                return ingredients;
            }
        }

        /// <summary>
        /// Price and Calories of T-Rex Burger
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// Called when bun is withheld
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// Called when lettuce is withheld
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Called when tomato is witheld
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// Called when onion is withheld
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// Called when pickle is withheld
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Called when ketchup is witheld
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Called when mustrard is withheld
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// Called when mayo is withheld
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}

