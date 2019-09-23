using DinoDiner.Menu.Entrees;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Represents the existence of bun 
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Represents the existence of peppers
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// Represents the existence of onions
        /// </summary>
        private bool onions = true;

        
        

        /// <summary>
        /// Constructs the brontworst
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if(onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Initial price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Called when bun is withheld
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// Called when peppers are withheld
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// Called when onions are withheld
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
    }
