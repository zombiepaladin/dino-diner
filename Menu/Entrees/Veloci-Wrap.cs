using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Represents the existence of dressing
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Represents the existence of lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Represents the existence of cheese
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// Gets and sets the price
        /// </summary>
     
        /// <summary>
        /// Creates the wrap
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" };
                ingredients.Add("Chicken Breast");
                
                
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Initial price and calories of wrap
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Called when dressing is withheld
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// Called when lettuce is withheld
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Called when cheese is withheld
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
        public override string ToString()
        {
            return ("Veloci-Wrap");
        }
    }
    }
