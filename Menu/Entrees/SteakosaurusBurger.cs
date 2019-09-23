using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
namespace Menu.Entrees
{
    public class SteakosaurusBurger : Entree
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
        /// Creates the burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Initial price and calories of burger
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Called when bun is withheld
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// Called when pickle is withheld
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Called when ketchup is withheld
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Called when mustard is withheld
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
    }
